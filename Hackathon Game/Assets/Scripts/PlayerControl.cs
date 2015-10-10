using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           //set the base player speed to the screen scroll rate
           // float xSpeed = 50;
           // Vector2 currentSpeed = GetComponent<Rigidbody2D>().velocity;

           //set the player's speed
           // if (currentSpeed.x < xSpeed)
           GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50f, ForceMode2D.Force);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * 50f, ForceMode2D.Force);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        }
    }
	
	// Update is called once per frame
	void Update () {

	}
}
