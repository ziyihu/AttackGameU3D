using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 0.3f;
	public float attack = 100;

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "SoulBoss" || col.tag == "SoulMonster") {
			col.GetComponent<ATKAndDamage>().TakeDamage(attack);
		}
	}
}
