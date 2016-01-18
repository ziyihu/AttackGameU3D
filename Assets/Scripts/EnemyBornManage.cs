using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBornManage : MonoBehaviour {

	public static EnemyBornManage _instance;

	public EnemyBorn[] monsterBornArray;
	public EnemyBorn[] bossBornArray;

	public List<GameObject> enemyList = new List<GameObject>();

	public AudioClip victoryClip;

	void Awake(){
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (Born ());
	}
	
	IEnumerator Born(){
		//the first enemy
		foreach(EnemyBorn s in monsterBornArray){
			enemyList.Add(s.Born());
		}

		while (enemyList.Count > 0) {
			yield return new WaitForSeconds(0.2f);
		}

		//the second enemy
		foreach(EnemyBorn s in monsterBornArray){
			enemyList.Add(s.Born());
		}
		yield return new WaitForSeconds(1f);
		foreach(EnemyBorn s in monsterBornArray){
			enemyList.Add(s.Born());
		}

		while (enemyList.Count > 0) {
			yield return new WaitForSeconds(0.2f);
		}

		//the third enemy
		foreach(EnemyBorn s in monsterBornArray){
			enemyList.Add(s.Born());
		}
		yield return new WaitForSeconds(1f);
		foreach(EnemyBorn s in monsterBornArray){
			enemyList.Add(s.Born());
		}
		yield return new WaitForSeconds(1f);
		foreach (EnemyBorn s in bossBornArray) {
			enemyList.Add(s.Born());
		}

		while (enemyList.Count  > 0) {
			yield return new WaitForSeconds(0.2f);
		}
		AudioSource.PlayClipAtPoint (victoryClip, transform.position, 1f);

	}
}
