using UnityEngine;


public class Jets : MonoBehaviour
{
	public Rigidbody2D rigidBody;

	public float speedMain;

	public float speedBrake;

	public float speedRotation;


	void Update()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		float speedVertical = moveHorizontal > 0 ? speedMain : speedBrake;
		Quaternion rotation = Quaternion.AngleAxis(rigidBody.rotation, Vector3.forward);

		rigidBody.AddForce(rotation * new Vector2(0.0f, moveVertical) * speedVertical * Time.deltaTime);
		rigidBody.AddTorque(-moveHorizontal * speedRotation * Time.deltaTime);
	}
}
