using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{

	public float health = 500;
	SceneLoader sceneloader;
	public GameObject deathEffect;

	public bool isInvulnerable = false;
	private void Start()
	{
		sceneloader = FindObjectOfType<SceneLoader>();
	}
	public void TakeDamage(float damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;

		if (health <= 300)
		{
			GetComponent<Animator>().SetBool("IsEnraged", true);
		}

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		
		Instantiate(deathEffect, transform.position, Quaternion.identity);
	

		sceneloader.LoadNextScene();
		Destroy(gameObject);	
		
	}

}
