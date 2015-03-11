using UnityEngine;
using System.Collections;

public class Player : Tank {
	Rigidbody rb;
	public float rotationSpeed = 3f;
	public float moveSpeed = 0.3f;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	determineWorldPos()
	{

	}
	undoVelocity()
	{
		if (rb.velocity != Vector3.zero) 
		{
			rb.velocity = Vector3.zero;	
		}
		if (rb.angularVelocity != Vector3.zero) 
		{
			rb.angularVelocity = Vector3.zero;	
		}

	}
	playerMovement()
	{
		if(Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector3.forward * moveSpeed);	
		}
		if(Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(-Vector3.forward * moveSpeed);
		}
		if(Input.GetKey (KeyCode.A)) 
		{
			transform.Rotate(-Vector3.up * rotationSpeed);	
		}
		if(Input.GetKey (KeyCode.D)) 
		{
			transform.Rotate(Vector3.up * rotationSpeed);	
		}
	}
	}
}
