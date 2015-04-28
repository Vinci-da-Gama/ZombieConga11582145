using UnityEngine;
using System.Collections;

public class GameOrgSenceTwo : MonoBehaviour {

	public PersonSenceTwo[] PersonsArray;
	// Use this for initialization
	void Start () {
		//select all objs in the same type.
		PersonsArray = Object.FindObjectsOfType (typeof(PersonSenceTwo)) as PersonSenceTwo[];
	}

	void OnGUI() {
		GUI.Label(new Rect(10, 10, 200, 20), "press space to cast 2 balls");
		GUI.Label(new Rect(10, 20, 200, 20), "Press H to Hide 3 red capsules");
		GUI.Label (new Rect(10, 30, 250, 20), "Press P to display Precent on Console");
		GUI.Label (new Rect(10,40,200, 20), "Press A to display Attack function");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.H))
		{
			//use find to get the obj, use BroadcastMessage to call Hide function
			//SendMessageOptions.DontRequireReceiver is to avoid receiving feedback message.
			//because there are many components like transform, mesh renderer... 
			//but only Enemy Basic component has Hide function, the others will return error message.
			GameObject.Find("Enemies").BroadcastMessage("Hide", SendMessageOptions.DontRequireReceiver);
		}

		if(Input.GetKeyDown(KeyCode.A))
		{
			StartCoroutine("PersonsAttack");
		}

	}

	private IEnumerator PersonsAttack()
	{
		foreach(PersonSenceTwo sigPerson in PersonsArray){
			StartCoroutine(sigPerson.Attack());
			yield return new WaitForSeconds (sigPerson.AttackDuraction);
		}
	}
}
