using UnityEngine;
using System.Collections;

public class Paina1 : MonoBehaviour {
	Rigidbody2D grabbedObject = null;
	public GameObject dot;
	GameObject sormi;
    public GameObject esteet;
    public static bool start = false;
	public Vector3 liikkuminen;
	float k = 1;
	public static bool pause = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
			pause = false;
                start = true;

            //painettu
			Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mouseWorldPos3D.x, mouseWorldPos3D.y);

			Vector2 dir = Vector2.zero;
			//Debug.Log (mousePos2D);

			sormi = Instantiate(dot, mousePos2D, transform.rotation);
			//Instantiate (dot, mousePos2D, transform.rotation);

			RaycastHit2D hitTest = Physics2D.Raycast (mousePos2D, dir);
			if (hitTest && hitTest.collider != null) {
				//Osui johonkin
				if (hitTest.collider.GetComponent<Rigidbody2D>() != null) {
                    grabbedObject = hitTest.collider.GetComponent<Rigidbody2D>();
                }
			}
		}

		if (Input.GetMouseButtonUp (0)) {
			Destroy (sormi);
			pauseGame ();
            
		}
	}

	void FixedUpdate () {
		if (grabbedObject != null) {
			Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 mousePos2D = new Vector2 (mouseWorldPos3D.x, mouseWorldPos3D.y);

			k = k + 0.005f;
			liikkuminen = new Vector3 (0,-k,0);

			if (pause != true) {
				for (int i = 0; i < esteet.transform.childCount; i++) {
					for(int o = 0; o <esteet.transform.GetChild(i).childCount;o++) {
						esteet.transform.GetChild (i).GetChild (o).GetComponent<Rigidbody2D> ().velocity = liikkuminen;
					}
				}
			} else {
				pauseGame();
			}
			grabbedObject.position = mousePos2D;
		}
	}

	void pauseGame() {
		start = false;
		pause = true;
        Handheld.Vibrate();

        for (int i = 0; i < esteet.transform.childCount; i++) {
			esteet.transform.GetChild (i).GetComponent<Rigidbody2D> ().velocity = new Vector3(0,0,0);
		}
		Application.LoadLevel("Menu_Score");
		grabbedObject = null;
	}
}
