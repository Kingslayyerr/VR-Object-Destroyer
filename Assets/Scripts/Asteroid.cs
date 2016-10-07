using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float y = Random.Range (0f, 360f);
		transform.rotation = Quaternion.Euler (0f, y, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 15.0f;

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
}
