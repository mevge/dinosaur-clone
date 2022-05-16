using UnityEngine;

public class CactusMovement : MonoBehaviour {
	
	void Update () {
		
		transform.position += new Vector3(-6f * Time.deltaTime, 0, 0);
		
		if(transform.position.x < -10){

			Destroy(gameObject);
		}
	}
}
