using UnityEngine;
using System.Collections;

public class GameManagerArray : MonoBehaviour {
	public EnemyBasic[] EnemyArray;
	// Use this for initialization
	void Start () {
		//select all objs in the same type.
		EnemyArray = Object.FindObjectsOfType (typeof(EnemyBasic)) as EnemyBasic[];
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.H))
		{
			foreach(EnemyBasic sigEnemy in EnemyArray){
				sigEnemy.Hide();
				Debug.Log("my name is: -- "+sigEnemy.name);
			}
		}
	}
}
