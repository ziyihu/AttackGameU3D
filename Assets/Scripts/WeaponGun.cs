using UnityEngine;
using System.Collections;

public class WeaponGun : MonoBehaviour {

	public Transform bulletPos;
	public GameObject bulletPerfab;
	public float attack = 100;

	public void Shot(){
		GameObject go = GameObject.Instantiate (bulletPerfab, bulletPos.position, transform.root.rotation) as GameObject;
		go.GetComponent<Bullet> ().attack = attack;
	}
	// Use this for initialization
	void Start () {
		//Destroy (this.gameObject, 3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
