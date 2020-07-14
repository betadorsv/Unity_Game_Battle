using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creep_run : MonoBehaviour
{

    public float speed = 2.5f;
    public float attackRange = 3f;
    public bool attack=false;
    public bool run = true;
    public Rigidbody2D rd2d;
    public Animator amin;
    public SpriteRenderer render;

    Transform player;
    Creep creep;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rd2d = gameObject.GetComponent<Rigidbody2D>();
        amin = gameObject.GetComponent<Animator>();
        render = gameObject.GetComponent<SpriteRenderer>();
        creep = gameObject.GetComponent<Animator>().GetComponent<Creep>();

    }

    // Update is called once per frame
    void Update()
    {
        amin.SetBool("Run", false);

        if (creep != null)
        {
            if (Mathf.Abs(transform.position.x - player.transform.position.x) < 7)
            {

                creep.LookAtPlayer();

                if (Vector2.Distance(player.position, rd2d.position) <= attackRange)
                {
                    amin.SetBool("Run", false);
                }
                else
                {
                    amin.SetBool("Run", true);
                }
                Vector2 target = new Vector2(player.position.x, rd2d.position.y);
                Vector2 newPos = Vector2.MoveTowards(rd2d.position, target, speed * Time.fixedDeltaTime);
                rd2d.MovePosition(newPos);

                if (Vector2.Distance(player.position, rd2d.position) <= attackRange)
                {

                    amin.SetTrigger("Attack");

                }
            }
        }
    }
    
}
