using UnityEngine;
using System.Collections;

public class ballMovement : MonoBehaviour {

    public bool active = false;
    private bool jumping = false;
    public float jumpForce = 100;
    public float moveSpeed = 10;
    private Rigidbody rb;
	// Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Update () {
        if (active)
        {
            rb.AddForce(Vector3.forward * (Input.GetAxis("Horizontal") * moveSpeed));

            if ((Input.GetButtonDown("Jump")) && (!jumping))
            {
                jumping = true;
                rb.AddForce(Vector3.up * jumpForce);
            }
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        jumping = false;
    }

    public void activate()
    {
        active = true;
    }

    public void deactivate()
    {
        active = false;
    }
}
