using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) {
		if(col.gameObject.tag == "dot")
		{
			Debug.Log("Maali");
			Paina1.start = false;
			Paina1.pause = true;
		}
	}
}
