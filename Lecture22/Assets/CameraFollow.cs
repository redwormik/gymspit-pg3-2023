using UnityEngine;


public class CameraFollow : MonoBehaviour
{
	public Camera followingCamera;


	// Start is called before the first frame update
	void Start()
	{
		followingCamera.transform.position = new Vector3(
			gameObject.transform.position.x,
			gameObject.transform.position.y,
			followingCamera.transform.position.z
		);
	}


	// Update is called once per frame
	void Update()
	{
		followingCamera.transform.position = new Vector3(
			gameObject.transform.position.x,
			gameObject.transform.position.y,
			followingCamera.transform.position.z
		);
	}
}
