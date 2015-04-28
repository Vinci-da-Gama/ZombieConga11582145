using UnityEngine;
using System.Collections;

public class PersonSenceTwo : MonoBehaviour {

	public float AttackDuraction = 2.0f;
	public float SpinSpeed=360.0f;

	public virtual IEnumerator Attack()
	{
		float ElapsedTime = 0;
		while(ElapsedTime<AttackDuraction)
		{
			transform.Rotate(new Vector3(0,SpinSpeed*Time.deltaTime,0));
			ElapsedTime += Time.deltaTime;

			yield return null;
		}
	}

}
