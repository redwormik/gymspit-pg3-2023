using UnityEngine;

public class AsteroidSplit : MonoBehaviour
{
	public GameObject prefab;


	public void OnFatalDamage(Health health)
	{
		GameObject leftHalf = GameObject.Instantiate(prefab);
		leftHalf.GetComponent<AsteroidSplit>().prefab = prefab;
		if (health.maxHealth > 1) {
			leftHalf.GetComponent<Health>().maxHealth = health.maxHealth - 1;
		}
	}
}
