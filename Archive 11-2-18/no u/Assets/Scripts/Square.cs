using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Square : MonoBehaviour {

    [SerializeField]

    GameObject ballPreFab;
    float speed = 2f;

    Vector3 velocity = new Vector3(0,0,0);

	// Use this for initialization
	void Start ()
    {
        
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey("left"))
        {
            transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z + 300 * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 300 * Time.deltaTime);
        }
        if (Input.GetKey("up"))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey("down"))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
        
        velocity.Normalize();

        transform.position += velocity * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
                GameObject newball = Instantiate(ballPreFab);
                newball.transform.position = transform.position;
                newball.GetComponent<Ball>().velocity = LookAtDirection(transform.eulerAngles.z);
                AudioManager.Instance.PlayOneShot(SoundEffect.shotedit);
        }
    }

    void MovementWASD()
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
    }

    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }
}
