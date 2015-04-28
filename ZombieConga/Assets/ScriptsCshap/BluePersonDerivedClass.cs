using UnityEngine;
using System.Collections;

public class BluePersonDerivedClass : PersonSenceTwo {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override IEnumerator Attack()
	{
		print ("Attack Hello World");
		yield return null;
	}
}
