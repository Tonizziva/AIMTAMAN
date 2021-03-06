﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour {
	public float speed = 1.0f;
	public Color color1;
	public Color Color2;
	public Color Color3;

	float startTime;

	void Start() {
		startTime = Time.time;
	}

	void Update() {
		float t = (Time.time - startTime) + speed;
		//Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1f));
		GetComponent<Renderer> ().material.color = Color.Lerp(Color.white, Color.black, Time.time - 10);

		if (GetComponent<Renderer> ().material.color == Color.black) {
			GetComponent<Renderer> ().material.color = Color.Lerp(Color.black, Color.red, Time.time - 20);
		}

	}
} 
