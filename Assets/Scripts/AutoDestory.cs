using UnityEngine;
using System.Collections;

public class AutoDestory : MonoBehaviour {
	public float exitTime = 1;
	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, exitTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
