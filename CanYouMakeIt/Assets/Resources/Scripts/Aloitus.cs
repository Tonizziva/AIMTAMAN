using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aloitus : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Launch()
    {
        Application.LoadLevel("Scene");
    }
	public void Exit()
	{
		Application.Quit ();
	}
}
