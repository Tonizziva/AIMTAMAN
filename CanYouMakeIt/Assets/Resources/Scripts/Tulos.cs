using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tulos : MonoBehaviour {
	public Text text;
	int tulos;

	// Use this for initialization
	void Start () {
		tulos = Counter.tulos;
		text.text = tulos.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
