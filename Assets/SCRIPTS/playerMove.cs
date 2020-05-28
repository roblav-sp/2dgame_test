using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    public bool face = false;
    public Transform HeroiT;
    public float speed = 10.0f;
    public float force = 10.0f;
    public Rigidbody2D heroiRB;

   //public Text txtmessage;

    // To jump
    public bool liberaPulo = true;
    public Transform check;
    public LayerMask wtground;
    public float radius = 1.5f;

    public bool attackmove = false;
    public Animator anim;
    public bool vivo = true;
    void Start()
    {
        HeroiT = GetComponent<Transform>();
        heroiRB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        wtground = GetComponent<LayerMask>();

    }

    // Update is called once per frame
    void Update()
    {
        if (vivo)
        {
           

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector2(speed * Time.deltaTime, 0));
                anim.SetBool("idle", false);
                anim.SetBool("walk", true);
                print("walking right");
                if (face)
                {
                    Flip();
                }

            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
                anim.SetBool("idle", false);
                anim.SetBool("walk", true);
                print("walking left");
                if (!face)
                {
                    Flip();
                }
            }
            else if (Input.GetKey(KeyCode.Mouse0))
            {
                anim.SetBool("idle", false);
                anim.SetBool("attack", true);
                attackmove = true;
                print("ATTACK");
                if (!liberaPulo)
                {
                    anim.SetBool("attack", false);
                    anim.SetBool("jumpattack", true);
                    print("JUMP ATTACK");
                }
                else
                {
                    anim.SetBool("jumpattack", false);
                }
            }
            else
            {
                attackmove = false;
                anim.SetBool("idle", true);
                anim.SetBool("walk", false);
                anim.SetBool("attack", false);
                anim.SetBool("jumpattack", false);
                print("idle");
            }

        }
        if (vivo)
        {
            print(liberaPulo); 
            if (Input.GetKeyDown(KeyCode.Space) && liberaPulo)
            {
                heroiRB.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
                anim.SetBool("jump", true);
                anim.SetBool("idle", false);

            }
            else
            {
               // Estou no chao ?
               liberaPulo = Physics2D.OverlapCircle(check.position, radius, wtground);
               //txtmessage.text = "!";
            }
        }
    }
    void Flip()
    {
        face = !face;
        Vector3 scala = HeroiT.localScale;
        scala.x *= -1;
        HeroiT.localScale = scala;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            // Removed bc using other form to do it see update main
            //liberaPulo = true;
            anim.SetBool("jump", false);
            //anim.SetBool("Idle", true);

        }

    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("ground"))
    //    {
    //        liberaPulo = false;
    //        // anim.SetBool("Idle", true);
    //
    //    }
    //}
    //
   // void OnTriggerEnter2D(Collider2D collision)
   // {
   //     if (collision.gameObject.CompareTag("enemy"))
   //     {
   //         print("collide");
   //         vivo = false;
   //         anim.SetBool("walk", false);
   //         anim.SetBool("die", true);
   //     }
   // }
}
