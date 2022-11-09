using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MUST HAVE Gyro Scope (Script) DEACTIVATED

public class MoveUnity : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

    }

	public float speed = 5.0f;		//defaults speed to 5 and allows for ajustment in inspector

	public GameObject character;	//allows definition of a GameObject "character" (this character is unused in rest of code)

	void Update()
	{
			Rigidbody rb = GetComponent<Rigidbody>();	//defines Rifidbody component of script reciever as "rb"
			if (Input.GetKey(KeyCode.A))			//if key A is pressed,
				rb.AddForce(Vector3.left);				//force is applied along Vector3 (-1,0,0)
			if (Input.GetKeyUp(KeyCode.A))			//if key A is released,
			    rb.velocity = Vector3.zero;				//velocity is set to 0
		        rb.angularVelocity = Vector3.zero;		//angular Velocity is set to 0

		    if (Input.GetKey(KeyCode.D))            //if key D is pressed,
				rb.AddForce(Vector3.right);             //force is applied along Vector3 (1,0,0)
			if (Input.GetKeyUp(KeyCode.D))			//if key D is released,
			    rb.velocity = Vector3.zero;				//velocity is set to 0
				rb.angularVelocity = Vector3.zero;		//angularVelocity is set to 0

		    if (Input.GetKey(KeyCode.W))			//if key W is pressed,
				rb.AddForce(Vector3.forward);			//force is applied along Vector3 (0,0,1)
		    if (Input.GetKeyUp(KeyCode.W))			//if key W is released,
			    rb.velocity = Vector3.zero;				//velocity is set to 0
		        rb.angularVelocity = Vector3.zero;		//angularVelocity is set to 0

		    if (Input.GetKey(KeyCode.S))			//if key S is pressed
				rb.AddForce(Vector3.back);				//force is applied along Vector3 (0,0,-1)
		    if (Input.GetKeyUp(KeyCode.S))			//if key S is released,
			    rb.velocity = Vector3.zero;				//velocity is set to 0
		        rb.angularVelocity = Vector3.zero;		//angularVelocity is set to 0

		//Rigidbody rb = GetComponent<Rigidbody>();
		//if (Input.GetKeyDown(KeyCode.A))
		//	rb.AddForce(Vector3.left);
		//if (Input.GetKeyDown(KeyCode.D))
		//	rb.AddForce(Vector3.right);
		//if (Input.GetKeyDown(KeyCode.W))
		//	rb.AddForce(Vector3.up);
		//if (Input.GetKeyDown(KeyCode.S))
		//	rb.AddForce(Vector3.down);

		//if (Input.GetKeyDown(KeyCode.D))
		//{
		//	transform.position += Vector3.right * speed * Time.deltaTime;
		//}
		//if (Input.GetKeyDown(KeyCode.A))
		//{
		//	transform.position += Vector3.left * speed * Time.deltaTime;
		//}
		//if (Input.GetKeyDown(KeyCode.W))
		//{
		//	transform.position += Vector3.forward * speed * Time.deltaTime;
		///}
		//if (Input.GetKeyDown(KeyCode.S))
		//{
		//	transform.position += Vector3.back * speed * Time.deltaTime;
		//}
	}
}
