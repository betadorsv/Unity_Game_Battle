using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPlayer : MonoBehaviour
{

    public float offset;
    public GameObject projectile;
    public Transform shotPoin;
    // Start is called before the first frame update
   

    // Update is called once per frame
    private void Update()
    {

        Vector3 difference = Camera.main.ScreenToViewportPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, shotPoin.position, transform.rotation);
        }
    }
}
