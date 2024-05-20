using UnityEngine;


public class RocketLauncher : MonoBehaviour
{
	public Rigidbody2D rocketShip;

	public GameObject rocketPrefab;

	public float speed;

	public float reloadTime = 0.5f;

	private float lastFireTime = 0.0f;


	void Update()
	{
		float time = Time.time;

		if (Input.GetButton("Fire1") && time > lastFireTime + reloadTime) {
			Quaternion rotation = Quaternion.AngleAxis(rocketShip.rotation, Vector3.forward);
			Vector2 deltaPosition = rotation * Vector2.up * 1.0f;

			GameObject rocket = Instantiate<GameObject>(rocketPrefab, rocketShip.position + deltaPosition, rotation);
			rocket.GetComponent<Rigidbody2D>().AddForce(rotation * Vector2.up * speed);
			rocketShip.AddForce(rotation * Vector2.down * speed);

			lastFireTime = time;
		}
	}
}
