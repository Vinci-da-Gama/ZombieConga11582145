using UnityEngine;
using System.Collections;

public class SpellBalls : MonoBehaviour {

	public float spellLife = 2.0f;
	public float spellSpeed = 10.0f;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (spellLife);
		Destroy (gameObject);
	}

	void OnCollisionEnter(Collision collisionSpell){
		if (collisionSpell.gameObject.tag != "RedEnemy")
		{
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * spellSpeed * Time.deltaTime, Space.Self);
	}
}
