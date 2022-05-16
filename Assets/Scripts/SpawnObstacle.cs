using UnityEngine;

public class SpawnObstacle : MonoBehaviour {
	
	public GameObject cactus1;
	public GameObject temp;
	public float minSpeed, maxSpeed, currentSpeed;

	void Start(){
		
		InvokeRepeating("SpawnObject", 1f, 2f);
	}

	void Awake(){
		
		currentSpeed = minSpeed;
	}

	public void SpawnObject(){

		temp = Instantiate(cactus1, transform.position, Quaternion.identity) as GameObject;	
	}
}
