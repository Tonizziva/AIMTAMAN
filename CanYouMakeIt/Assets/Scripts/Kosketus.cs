using UnityEngine;
using System.Collections;

public class Kosketus : MonoBehaviour
{
    Rigidbody2D grabbedObject = null;
    public GameObject dot;
    GameObject sormi;
    public GameObject esteet;
    public static bool start = false;
    public Vector3 liikkuminen;
    float k = 1;
    public static bool pause = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);

            Vector2 dir = Vector2.zero;

            start = true;

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    for (int i = 0; i < esteet.transform.childCount; i++)
                    {
                        esteet.transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = liikkuminen;
                    }
                    //painettu
                    

                    sormi = Instantiate(dot, mousePos2D, transform.rotation);
                    //Instantiate (dot, mousePos2D, transform.rotation);

                    RaycastHit2D hitTest = Physics2D.Raycast(mousePos2D, dir);
                    if (hitTest && hitTest.collider != null)
                    {
                        //Osui johonkin
                        if (hitTest.collider.GetComponent<Rigidbody2D>() != null)
                        {
                            grabbedObject = hitTest.collider.GetComponent<Rigidbody2D>();
                        }
                    }
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Ended:
                    Destroy(sormi);
                    pauseGame();
                    break;
            }
        }
    }

    void FixedUpdate()
    {
        if (grabbedObject != null)
        {
            Vector3 mouseWorldPos3D = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mouseWorldPos3D.x, mouseWorldPos3D.y);
            k = k + 0.01f;
            liikkuminen = new Vector3(0, -k, 0);
            if (pause != true)
            {
                for (int i = 0; i < esteet.transform.childCount; i++)
                {
                    esteet.transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = liikkuminen;
                }
            }
            else
            {
                pauseGame();
            }
            grabbedObject.position = mousePos2D;
        }
    }

    void pauseGame()
    {
        start = false;
        pause = true;
        for (int i = 0; i < esteet.transform.childCount; i++)
        {
            esteet.transform.GetChild(i).GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        }
        Application.LoadLevel("Scene");
        grabbedObject = null;
    }
}
