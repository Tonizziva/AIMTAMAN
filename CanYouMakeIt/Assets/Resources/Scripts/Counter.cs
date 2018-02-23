using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Counter : MonoBehaviour {
    public Text laskuri;
    public static int tulos = 0;

	// Use this for initialization
	void Start () {
		tulos = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Paina1.start == true)
        {
            tulos = tulos + 1;
            laskuri.text = tulos.ToString();
        }
    }
}
