using UnityEngine;
using System.Collections;

public class ParentTransformSenceThree : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.ChildrenTransform ();
	}
	
	// Update is called once per frame
	void Update () {
		this.ParenyTransform ();
	}

	private void ChildrenTransform()
	{
		for(int i = 0; i<transform.childCount; i++)
		{
			Transform childrenTransform = transform.GetChild(i);
			Debug.Log("From Parent the child is: -- "+childrenTransform.gameObject.name);
		}
	}

	private void ParenyTransform()
	{
		transform.position = new Vector3 (transform.position.x, Mathf.PingPong(Time.time, 2), 
		                                  transform.position.z);
		transform.Rotate (0, 90 * Time.deltaTime, 0);
		transform.localScale = new Vector3 (Mathf.PingPong(Time.time, 3),Mathf.PingPong(Time.time, 3),
		                                    Mathf.PingPong(Time.time, 3));
	}
}
