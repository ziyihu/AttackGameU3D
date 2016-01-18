﻿using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {

	private bool isPress = false;
	private Transform button;

	public static float h = 0;
	public static float v = 0;

	void Awake(){
		button = transform.Find("Button");
	}

	void OnPress(bool isPress){
		this.isPress = isPress;
		if (isPress == false) {
			button.localPosition = Vector3.zero;
			h = 0;
			v = 0;
		}
	}

	void Update(){
		if (isPress) {
			Vector2 touchPos = UICamera.lastTouchPosition;
			touchPos -= new Vector2(73,73);
			float distance = Vector2.Distance(Vector2.zero,touchPos);
			if(distance > 59){
				touchPos = touchPos.normalized * 59;
				button.localPosition = touchPos;
			} else {
				button.localPosition = touchPos;
			}

			h = touchPos.x/59;
			v = touchPos.y/59;
		}
	}
}
