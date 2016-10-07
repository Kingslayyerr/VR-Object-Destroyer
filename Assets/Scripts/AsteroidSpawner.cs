using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

	public GameObject Asteroid;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 14; i++)
		{
			GameObject asteroid = (GameObject)Instantiate (Asteroid, new Vector3 (Random.Range (-140f, 140f), 0f, Random.Range (-140, 140f)), Quaternion.identity);

			if (asteroid.transform.position.x < 30f && asteroid.transform.position.x > 0f)
			{
				asteroid.transform.position = new Vector3 (Random.Range (30f, 140f), 0f, asteroid.transform.position.z);
			}

			else if (asteroid.transform.position.x > -30f && asteroid.transform.position.x < 0f)
			{
				asteroid.transform.position = new Vector3 (Random.Range (-140f, -30f), 0f, asteroid.transform.position.z);
			}

			if (asteroid.transform.position.z < 30f && asteroid.transform.position.z > 0f)
			{
				asteroid.transform.position = new Vector3 (asteroid.transform.position.x, 0f, Random.Range (30f, 140f));
			}

			else if (asteroid.transform.position.z > -30f && asteroid.transform.position.z < 0f)
			{
				asteroid.transform.position = new Vector3 (asteroid.transform.position.x, 0f, Random.Range (-140f, -30f));
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
