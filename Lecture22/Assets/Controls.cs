using UnityEngine;


public class Controls : MonoBehaviour
{
	public Rigidbody2D rigidBody;

	public float speed;


	// Start is called before the first frame update
	void Start()
	{

	}


	// Update is called once per frame
	void Update()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");	

		// rigidBody.position += new Vector2(moveHorizontal, moveVertical) * speed * Time.deltaTime;
		// rigidBody.velocity += new Vector2(moveHorizontal, moveVertical) * speed * Time.deltaTime;
		rigidBody.AddForce(new Vector2(moveHorizontal, moveVertical) * speed * Time.deltaTime);
	}
}
