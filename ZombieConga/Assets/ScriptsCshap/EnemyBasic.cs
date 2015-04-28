using UnityEngine;
using System.Collections;

public class EnemyBasic : MonoBehaviour {

	public int Health = 100;
	public int MagicPoints = 100;


	internal void Hide()
	{
		print ("Enemy Hide");
		gameObject.SetActive (false);
	}
}