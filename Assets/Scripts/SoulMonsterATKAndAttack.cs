using UnityEngine;
using System.Collections;

public class SoulMonsterATKAndAttack : ATKAndDamage {

	private Transform player;

	void Awake(){
		base.Awake ();
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	public void MonAttack(){
		if (Vector3.Distance (transform.position, player.position) < attackDistance) {
			player.GetComponent<ATKAndDamage>().TakeDamage(normalAttack);
		}
	}

	void Update(){
//		if (this.hp <= 0) {
//			animator.SetBool("Dead",true);
//			EnemyBornManage._instance.enemyList.Remove(this.gameObject);
//			Destroy(this.gameObject,1);
//			this.GetComponent<CharacterController>().enabled = false;
//		}
	}
}
