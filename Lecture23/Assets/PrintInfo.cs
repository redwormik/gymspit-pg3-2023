using UnityEngine;
using UnityEngine.UI;


public class PrintInfo : MonoBehaviour
{
	public Text text;

	// Start is called before the first frame update
	void Start()
	{
		UpdateInfo();
	}

	// Update is called once per frame
	void Update()
	{
		UpdateInfo();
	}


	private void UpdateInfo()
	{
		Rigidbody2D rigidbody = gameObject.GetComponent<Rigidbody2D>();

		text.text = "X: " + transform.position.x + "\n" +
			"Y: " + transform.position.y + "\n" +
			"rot.: " + transform.rotation.eulerAngles.z + "\n" +
			"X': " + rigidbody.velocity.x + "\n" +
			"Y': " + rigidbody.velocity.y + "\n" +
			"rot.': " + rigidbody.angularVelocity;
	}
}
