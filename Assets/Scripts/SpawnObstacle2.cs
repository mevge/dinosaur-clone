using UnityEngine;

public class SpawnObstacle2 : MonoBehaviour {

	public GameObject cactus2;
	public GameObject temp;
	public float minSpeed, maxSpeed, currentSpeed;

	void Start(){

		InvokeRepeating("SpawnObject", 5f, Random.Range(2.5f, 5f));
	}

	void Awake(){

		currentSpeed = minSpeed;
	}

	public void SpawnObject(){

			temp = Instantiate(cactus2, transform.position, Quaternion.identity) as GameObject;	
	}
}
