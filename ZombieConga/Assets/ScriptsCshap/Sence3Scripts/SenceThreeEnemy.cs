using UnityEngine;
using System.Collections;

public class SenceThreeEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	internal void OnKeyEvent(){
		print ("This is OBJ name: -- "+gameObject.name+" Type: -- "+gameObject.GetType()+
		       " InstanceID: --  "+gameObject.GetInstanceID()+" layer is: -- "+gameObject.layer+
		       " tag is: -- "+gameObject.tag+" - You Press E key (E key activeate This Event)");
	}

	internal void KeyExtraEvent(){
		Debug.Log ("One Extra Key Event. Press Key to display gameObject Information");
//		GUI.Label (new Rect(10, 10, 200, 20), "Key E event, one more.");
		this.OnGUI ();
	}

	private void OnGUI()
	{
		GUI.Label(new Rect(10, 10, 200, 20), "Key E event, one more.");
	}
}
