using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    public float vel = 2.5f;
    public float jumpforce = 500f;
    public int jumps = 2;
    public Rigidbody2D bird;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float H = Input.GetAxis("Horizontal") * vel * Time.deltaTime;
        float V = Input.GetAxis("Vertical")* vel * Time.deltaTime;
       
        transform.Translate(new Vector3(H , 0 , 0));
        if(jumps>0)
        {   
            if(Input.GetKeyDown(KeyCode.Space))
            {
                bird.AddForce(new Vector2(0, jumpforce * Time.deltaTime), ForceMode2D.Impulse);
                jumps--;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("ground")) 
        {
            jumps = 2;
            
        }
    }
    void OnCollisionExit2D(Collision2D outro) 
    {
        if (outro.gameObject.CompareTag("ground"))
        {
            //canjump = false;
            
        }

    }
    
}
