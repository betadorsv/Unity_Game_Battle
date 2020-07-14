using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreepHealthBar : MonoBehaviour
{
	public CreepHealth creepHealth;

	Vector3 localScale;
	float scale;
	float health = 1463;
	void Start()
	{
		localScale = transform.localScale;
	}

	// Update is called once per frame
	void Update()
	{
		scale=creepHealth.health/health‬;
		localScale.x=scale;
		transform.localScale = localScale;
	}
}
