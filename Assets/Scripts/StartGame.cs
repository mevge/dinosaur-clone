using UnityEngine;

public class StartGame : MonoBehaviour {

	public GameObject textObject, highScoreTable, counter;
	public PlayerManager playerManager;

	private void Start() {
		
		playerManager.GetComponent<Animator>().enabled = false;
		counter.SetActive(false);
	}

	void Awake(){
		
		Time.timeScale = 0f;
	}

	void Update() {

		if(Input.GetMouseButtonDown(0)){
			
			playerManager.GetComponent<Animator>().enabled = true;
			counter.SetActive(true);
			Destroy(playerManager.highScoreBoard);
			Destroy(highScoreTable);
			Destroy(textObject);
			Time.timeScale = 1f;
		}
	}
}
