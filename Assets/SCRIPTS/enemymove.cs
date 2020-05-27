using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    public float speed = 1.0f;
    public bool follow = false;
    public float distance;
    public Transform Hero;
    public bool face = true;
    public Animator enemy;


    void Start()
    {
        enemy = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(this.transform.position, Hero.transform.position);
        if ((Hero.transform.position.x >this.transform.position.x) && face)
        {
            Flip();
        }
        else if((Hero.transform.position.x< this.transform.position.x)&& !face)
        {
            Flip();
        }
        if ((follow)&& distance >1.6f)
        {
            if(Hero.transform.position.x < this.transform.position.x)
            {
                transform.Translate(new Vector2 (-speed * Time.deltaTime, 0));
                enemy.SetBool("enemywalk", true);
                enemy.SetBool("enemyidle", false);
            }
            else if(Hero.transform.position.x > this.transform.position.x)
            {
                transform.Translate(new Vector2( speed * Time.deltaTime, 0));
                enemy.SetBool("enemywalk", true);
                enemy.SetBool("enemyidle", false);
            }

        }
        else
        {   
            // TODO FUTURE
            enemy.SetBool("enemywalk", false);
            enemy.SetBool("enemyidle", true);
        }
    }
    void Flip()
    {
        face = !face;
        Vector3 scala = this.transform.localScale;
        scala.x *= -1;
        this.transform.localScale = scala;
    }
    void OnTriggerEnter2D(Collider2D followit)
    {
        if (followit.gameObject.CompareTag("player"))
        {
            print("enemy attack");
            follow = true;
        }
    }
}
