using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHelth_bar : MonoBehaviour
{
	public BossHealth bossHealth;

	Vector3 localScale;
	float scale;
	float health = 1000;
	void Start()
	{
		localScale = transform.localScale;
	}

	// Update is called once per frame
	void Update()
	{
		scale = bossHealth.health / health‬;
		localScale.x = scale;
		transform.localScale = localScale;
	}
}
