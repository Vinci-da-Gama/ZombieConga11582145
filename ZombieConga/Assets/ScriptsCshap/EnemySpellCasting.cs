using UnityEngine;
using System.Collections;

public class EnemySpellCasting : MonoBehaviour {

	public GameObject SpellMagicBall;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space))
		{
			this.CastSpell(0);
		}
	}

	private void CastSpell(int spellID = 0, int MinimumPoints = 50)
	{
		EnemyBasic enemyBasicBody = GetComponent<EnemyBasic> ();
		if (enemyBasicBody.MagicPoints >= MinimumPoints) {
			enemyBasicBody.MagicPoints -= MinimumPoints;
			Debug.Log ("Has Enough MagicPoint to Cast Spell");
			Instantiate(SpellMagicBall);
		}
		else {
			Debug.Log("Donot has enough MagicPoints to Cast!!!!!");
		}
	}
}
