using UnityEngine;


public class FollowObject : MonoBehaviour
{
	public GameObject followedObject;


	void Start()
	{
		UpdateTransform();
	}


	void Update()
	{
		UpdateTransform();
	}


	private void UpdateTransform()
	{
		transform.position = new Vector3(
			followedObject.transform.position.x,
			followedObject.transform.position.y,
			transform.position.z
		);

		transform.rotation = followedObject.transform.rotation;
	}
}
