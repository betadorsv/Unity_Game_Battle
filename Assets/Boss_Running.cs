using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Running : MonoBehaviour
{
    Animator animator;
    AnimatorStateInfo stateInfo;
    int layerIndex;
    public float speed = 2.5f;
    public float attackRange = 3f;
    Transform bosss;
    Transform player;
    Rigidbody2D rb;
    Boss boss;

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        bosss = GameObject.FindGameObjectWithTag("Boss").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        boss = animator.GetComponent<Boss>();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

 
}
