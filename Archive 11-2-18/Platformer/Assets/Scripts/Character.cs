using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public List<Vector3> teleportLocations = new List<Vector3>();

    int jump = 4;
    int speed = 2;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;

	// Use this for initialization
	void Start ()
    {

        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.U))
            GameManager.Instance.Character = this;
        velocity = rbody.velocity;
		if (Input.GetKeyDown("up"))
        {
            velocity += Vector3.up * jump;
            AudioManager.Instance.PlayOneShot(SoundEffect.ree);
        }
        if (Input.GetKey("left"))
        {
            velocity -= Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            velocity += Vector3.right * speed * Time.deltaTime;
        }
        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -2, 2), Mathf.Clamp(velocity.y, -7, 7));
	}


    public void OnClickTeleportButton()
    {
        transform.position = teleportLocations[Random.Range(0, teleportLocations.Count)];
    }
}
