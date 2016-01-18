using UnityEngine;
using System.Collections;

public class SoulMonster : MonoBehaviour {

	private Transform player;
	//attack distance and follow distance
	public float attackDistance = 0.8f;
	//moving speed
	public float speed = 3;
	public float attackTime = 3;
	private float attackTimer = 0;
	private CharacterController cc;

	private PlayerATKAndDamage playerAtkAndDamge;

	private Animator animator;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerAtkAndDamge = player.GetComponent<PlayerATKAndDamage> ();
		cc = this.GetComponent<CharacterController> ();
		animator = this.GetComponent<Animator> ();
		attackTimer = attackTime;
	}

	void Update(){
		if (playerAtkAndDamge.hp <= 0) {
			animator.SetBool("Walk", false);
			return;
		}
		Vector3 targetPos = player.position;
		targetPos.y = transform.position.y;
		transform.LookAt(targetPos);
		float distance = Vector3.Distance(targetPos, transform.position);
		if (distance <= attackDistance) {
			attackTimer += Time.deltaTime;
			if (attackTimer > attackTime) {
				animator.SetTrigger("Attack");
				attackTimer = 0;
			} else {
				animator.SetBool("Walk", false);
			}
		} else {
			attackTimer = attackTime;
			if (animator.GetCurrentAnimatorStateInfo(0).IsName("MonRun")) {
				cc.SimpleMove(transform.forward * speed);
			}
			animator.SetBool("Walk", true);
		}
	}
}
