using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepHealth : MonoBehaviour
{
	public float health = 200;

	public GameObject deathEffect;

	public bool isInvulnerable = false;

	public void TakeDamage(float damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;


		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		FindObjectOfType<AudioManager>().Play("Death");

		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}
