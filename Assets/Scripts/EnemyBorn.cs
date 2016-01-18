using UnityEngine;
using System.Collections;

public class EnemyBorn : MonoBehaviour {

	public GameObject prefab;

	public GameObject Born(){
		return GameObject.Instantiate (prefab, transform.position, transform.rotation) as GameObject;
	}
}
