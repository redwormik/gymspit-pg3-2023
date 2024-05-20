using UnityEngine;


public class Health : MonoBehaviour
{
	public int maxHealth;

	public int CurrentHealth { get; private set; }


	void Start()
	{
		CurrentHealth = maxHealth;
	}


	public void ApplyDamage(int damage)
	{
		CurrentHealth -= damage;
		gameObject.SendMessage("OnDamage", this, SendMessageOptions.DontRequireReceiver);
		if (CurrentHealth <= 0) {
			gameObject.SendMessage("OnFatalDamage", this, SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
