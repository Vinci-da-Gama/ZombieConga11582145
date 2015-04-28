using UnityEngine;
using System.Collections;

public class GameManagerSenceThree : MonoBehaviour {
	public delegate void KeyEvent();

	internal KeyEvent UserPressKey;
	// Use this for initialization
	void Start () {
		SenceThreeEnemy[] sence3EnemyArr = Object.FindObjectsOfType (typeof(SenceThreeEnemy)) as SenceThreeEnemy[];
//		SenceThreeEnemy oneSample = new SenceThreeEnemy ();

		foreach(SenceThreeEnemy sigEnemy in sence3EnemyArr){
			UserPressKey += sigEnemy.OnKeyEvent;
			if(sigEnemy.name == "Person 1"){
				UserPressKey += sigEnemy.KeyExtraEvent;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		this.PressEkeyFunc ();
	}

	private void PressEkeyFunc()
	{
		if (Input.GetKeyDown (KeyCode.E)) {
			UserPressKey();
		}
	}

}
