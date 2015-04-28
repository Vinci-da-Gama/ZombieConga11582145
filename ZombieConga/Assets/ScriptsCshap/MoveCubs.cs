using UnityEngine;
using System.Collections;

public class MoveCubs : MonoBehaviour {
	public GameObject[] Cubes;
	public Vector3 TRanslateSpeed = Vector3.zero;
	public float MaxY = 16.0f;

	IEnumerator MoveCubsCoRoutine()
	{
		yield return new WaitForSeconds(2.0f);

		foreach (GameObject theBox in Cubes) 
		{
			while (theBox.transform.position.y<MaxY) 
			{
				theBox.transform.Translate(TRanslateSpeed.x*Time.deltaTime, 
				TRanslateSpeed.y*Time.deltaTime, TRanslateSpeed.z*Time.deltaTime);
				yield return null;
			}
			yield return new WaitForSeconds(1.0f);
			Debug.Log("Sequence Completed.");
		}
	}


	void Start()
	{
		// one feature of start StartCoroutine is 
		// it is not pause when excuting funcion inside.
		// It runs parallel with codes below.
		// add Debug.Log() as example
//		StartCoroutine(MoveCubsCoRoutine ());
		// Debug.Log('wocao');

//		another way To Start Coroutine
//		StopCoroutine can only stop Coroutine in the form below.
		StartCoroutine ("MoveCubsCoRoutine");
//		StopCoroutine ("MoveCubsCoRoutine");



	}

	void Update(){

	}
}
