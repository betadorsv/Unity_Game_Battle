using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabWeapon : MonoBehaviour {

	

	// Update is called once per frame



	//public float offset;
	//public Transform weapontransform;
	public GameObject projectile;
	public Transform shotPoin;
	public Joybutton joybutton;
	
	void Update () {
		
				if(Input.GetButtonDown("Fire1") || joybutton.Pressed)
				{
					Shoot();
			joybutton.Pressed = false;
		}
		
		//Vector2 difference = Camera.main.ScreenToViewportPoint(Input.mousePosition) - weapontransform.position;
		//	float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
		//weapontransform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
		//	if (Input.GetMouseButtonDown(0))
		//	{
		//	Instantiate(projectile, shotPoin.position, weapontransform.rotation);
		//}
	}
	public void Shoot()
	{

		Instantiate(projectile, shotPoin.position, shotPoin.rotation);
		FindObjectOfType<AudioManager>().Play("Shotgun");
	}

}
