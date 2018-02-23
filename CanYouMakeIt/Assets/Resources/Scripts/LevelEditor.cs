using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditor : MonoBehaviour {
	public GameObject este0;
	public GameObject este1;
	public GameObject este2;
	public GameObject este3;
	public GameObject este4;
	public GameObject este5;
	public GameObject esteet;

	public Transform esterata2;
	GameObject esterata;

	// Use this for initialization
	void Start () {
		for (int i=0;i<50;i++) {
			int r = Random.Range (1, 7);
			GameObject obj = GameObject.Find ("Assets/Resources/Prefabs/este0");
			//Debug.Log (Resources.Load("Prefabs/Este"+r));

			esterata2 = (Instantiate(Resources.Load("Prefabs/Este"+r),	new Vector2(0.7f, (i+1)*4), Quaternion.identity) as GameObject).transform.parent = esteet.transform;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
}
