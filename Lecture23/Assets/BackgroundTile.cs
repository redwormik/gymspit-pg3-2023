using System;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{
	private const float epsilon = 0.001f;

	public GameObject target;

	public float size = 10.0f;

	private float lastScale;

	// Start is called before the first frame update
	void Start()
	{
		UpdateScale();
	}


	// Update is called once per frame
	void Update()
	{
		UpdateScale();

		float sizeX = transform.localScale.x * size;
		float sizeY = transform.localScale.y * size;

		if (
			Math.Abs(transform.position.x - target.transform.position.x) >= sizeX / 2.0f ||
			Math.Abs(transform.position.y - target.transform.position.y) >= sizeY / 2.0f
		) {
			transform.position = new Vector3(
				(float) Math.Round(target.transform.position.x / sizeX) * sizeX,
				(float) Math.Round(target.transform.position.y / sizeY) * sizeY,
				transform.position.z
			);
		}
	}


	void UpdateScale()
	{
		float scale = (float) Camera.main.orthographicSize * 2.0f *
			Math.Max((float) Screen.width / Screen.height, 1.0f);
		
		if (Math.Abs(scale - lastScale) < epsilon) {
			return;
		}

		transform.localScale = new Vector3(
			scale / size,
			scale / size,
			transform.localScale.z
		);

		lastScale = scale;
	}
}
