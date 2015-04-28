using UnityEngine;
using System.Collections;

public class SenceThreeGameOBJ : MonoBehaviour {

	public GameObject[] theOBJs;

	void OnGUI()
	{
		GUI.Label(new Rect(10, 30, 200, 20), "Press Y,U or I to find different OBJs");
	}
	// Use this for initialization
	void Start () {
	}

	private void KeyY()
	{
		if(Input.GetKeyDown(KeyCode.Y))
		{
			theOBJs = GameObject.FindGameObjectsWithTag ("EmptyOBJinGame");
		}
	}
	
	private void KeyU()
	{
		if(Input.GetKeyDown(KeyCode.U))
		{
			theOBJs = GameObject.FindGameObjectsWithTag ("CaoOBJ");
		}

	}
	
	private void KeyI()
	{
		if(Input.GetKeyDown(KeyCode.I))
		{
			theOBJs = GameObject.FindGameObjectsWithTag ("Bao_OBJ");
		}
	}

	void Update (){
		this.KeyY ();
		this.KeyU ();
		this.KeyI ();	
	}
}
