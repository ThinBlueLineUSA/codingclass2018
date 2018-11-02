using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSnawkee : MonoBehaviour {
    [SerializeField]

    float speed = 2f;

    Vector3 velocity = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start ()
    {
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
    }
	
	// Update is called once per frame
	void Update ()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey("up"))
        {
            if (transform.position.y < 1f)
            {
                velocity += Vector3.up;
            }
        }
        if (Input.GetKey("left"))
        {
            if (transform.position.x > -1.75f)
            {
                velocity += Vector3.left;
            }
        }
        if (Input.GetKey("down"))
        {
            if (transform.position.y > -1f)
            {
                velocity += Vector3.down;
            }
        }
        if (Input.GetKey("right"))
        {
            if (transform.position.x < 1.75f)
            {
                velocity += Vector3.right;
            }
        }
        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * speed;


    }
}
