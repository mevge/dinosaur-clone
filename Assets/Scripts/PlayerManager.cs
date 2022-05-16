using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

	//Component assignment
	private Rigidbody2D rigidBody2D;
	public TextMesh counterBoard, highScoreBoard;
	[HideInInspector]
	public Animator animator;

	//Value assignment
	public float jumpForce;
	public bool isGrounded;
	private float counter, highScore;
	private string currentAnimation;


	//Animation states
	const string playerRun = "dinosaur-run";
	const string playerJump = "dinosaur-jump";

	void Start(){
		
		rigidBody2D = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		highScoreBoard.text = PlayerPrefs.GetFloat("highscore").ToString("#.00");
	}

	void Update (){

		if(Input.GetMouseButtonDown(0) && isGrounded == true){
			
			ChangeAnimationState(playerJump);
			rigidBody2D.AddForce(Vector2.up * jumpForce);
			isGrounded = false;
		}

		counter += Time.deltaTime * 4;
		counterBoard.text = counter.ToString("f");

		if(counter > PlayerPrefs.GetFloat("highscore")){

			PlayerPrefs.SetFloat("highscore", counter);
		}
	}
	
	public void ChangeAnimationState(string newAnimation){

		if(currentAnimation == newAnimation) return;

		animator.Play(newAnimation);
		currentAnimation = newAnimation;
	}

	private void OnCollisionEnter2D(Collision2D other) {
		if(other.gameObject.tag == "Platform"){

			ChangeAnimationState(playerRun);
			isGrounded = true;
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Obstacle"){
			
			Destroy(gameObject, 0.1f);
			SceneManager.LoadScene("Scene02");
		}
	}
}
