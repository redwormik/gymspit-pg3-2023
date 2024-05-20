using UnityEngine;


public class Projectile : MonoBehaviour
{
	public int damage = 1;

	public string targetTag;

	public string message = "ApplyDamage";


	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag(targetTag)) {
			collision.gameObject.SendMessage(message, damage);
			Destroy(gameObject);
		}
	}
}
