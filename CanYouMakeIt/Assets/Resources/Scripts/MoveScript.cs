using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
	public Vector2 move;
    public bool liikuAina;

    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        if (liikuAina == false)
        {
            if (Paina1.pause == false)
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = move;
            }
        } else
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = move;
        }
    }
}
