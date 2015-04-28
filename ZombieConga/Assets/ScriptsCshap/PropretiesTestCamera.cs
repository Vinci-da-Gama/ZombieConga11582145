using UnityEngine;
using System.Collections;

public class PropretiesTestCamera : MonoBehaviour {

	public float PrecentDisplay {
		get{
			return this.PrecentFormat*100;
		}
		set{
			PrecentFormat = value/100;
		}
	}
	private float PrecentFormat = 0.0f;
	// Use this for initialization
	void Start () {
		PrecentDisplay = 75;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			Debug.Log ("PrecentFormat is "+this.PrecentFormat);
			Debug.Log ("PrecentDisplay is "+PrecentDisplay);
		}
	}
}
