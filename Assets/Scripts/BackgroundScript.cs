using UnityEngine;

public class BackgroundScript : MonoBehaviour {
	
	private Vector2 offset;
	private Material material;
	public float velX, velY;

	void Start()
	{

		material = GetComponent<Renderer>().material;
		offset = new Vector2(velX, velY);
	}
	
	void Update () {

		material.mainTextureOffset += offset * Time.deltaTime;
	}
}
