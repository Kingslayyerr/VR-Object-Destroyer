using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// IMPORTANT FOR FUTURE VR PROJECTS
	private Transform HeadTransform; // tracks the players head through its transform property


	void Start ()
	{
		// Since this script will be attached to the GVR MAIN prefab we can use GVR MAINS transform by calling FindChild onnit.
		HeadTransform = transform.FindChild ("Head"); 
	}

	void Update ()
	{
		// Confines the transforms y vector to 0 
		Vector3 forward = new Vector3 (HeadTransform.forward.x, 0f, HeadTransform.forward.z);

		//normalizes the length so that there will not
		// be variations in speed which cause dizziness in VR.
		forward.Normalize ();


		// This is the piece of code that makes the object move
		// might be better to move to a trigger event to make the player move only when button is clicked.
		transform.position += forward * Time.deltaTime * 20.0f; 


		// if the players head is more than the max allowed(our quads x positions.. -150,150)
		if(transform.position.x >= 148f)
		{
			// do something
			transform.position = new Vector3 (-148f, 0f, transform.position.z);
		} 
		// if the player head is less than the max allowed(our quads x positions)
		else if (transform.position.x <= -148f)
		{
			transform.position = new Vector3 (148f, 0f, transform.position.z);
		}
		// same idea as above but now dealing with the zed axis.
		else if (transform.position.z >= 148f)
		{
			transform.position = new Vector3 (transform.position.x, 0f, -148f);
		}
		else if (transform.position.z <= -148f)
		{
			transform.position = new Vector3 (transform.position.x, 0f, 148f);
		}

	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Asteroid") 
		{
			Destroy (collision.gameObject);
		}

	}
}
