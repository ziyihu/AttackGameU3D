﻿using UnityEngine;
using System.Collections;

public class ATKAndDamage : MonoBehaviour {

	public float hp = 100;
	public float normalAttack = 50;
	public float attackDistance = 1;
	protected Animator animator;

	public AudioClip deathClip;

	protected void Awake(){
		animator = this.GetComponent<Animator> ();
	}

	public virtual void TakeDamage(float damage){
		if (hp > 0) {
			hp -= damage;

		}

		if (hp > 0) {
			if(this.tag == "SoulBoss" || this.tag == "SoulMonster"){
				animator.SetTrigger("Damage");
			}
		
		} else {
			animator.SetBool("Dead",true);
			AudioSource.PlayClipAtPoint(deathClip,transform.position,1f);
			if(this.tag == "SoulBoss" || this.tag == "SoulMonster"){
				EnemyBornManage._instance.enemyList.Remove(this.gameObject);
				SpwanAward();
				Destroy(this.gameObject,1);
				this.GetComponent<CharacterController>().enabled = false;

			} 
		}

		if(this.tag == "SoulBoss"){
			GameObject.Instantiate(Resources.Load("HitBoss"), transform.position+Vector3.up, transform.rotation);
		} else if(this.tag == "SoulMonster"){
			GameObject.Instantiate(Resources.Load("HitMonster"),transform.position+Vector3.up,transform.rotation);
		}
	}

	void SpwanAward(){
		int count = Random.Range(1,100);
		if(count > 50){
			int index = Random.Range(0,2);
			if(index == 0){
				GameObject.Instantiate(Resources.Load("Item-DualSword"),transform.position+Vector3.up,Quaternion.identity);
			} else if(index == 1){
				GameObject.Instantiate(Resources.Load("Item-Gun"),transform.position+Vector3.up,Quaternion.identity);
			}
		}
	}
}
