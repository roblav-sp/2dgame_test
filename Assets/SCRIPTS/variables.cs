using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    // Start is called before the first frame update

    public float vel = 2.5f;
    //public Renderer quad;
    
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(0.1f,0,0));
        //transform.Rotate(new Vector3(0,0,0.1f));
        //transform.localScale += new Vector3(0.2f,0.2f,0);
        //Vector2 offset =new Vector2(vel = Time.deltaTime ,0);
        //quad.material.mainTextureOffset += offset;
        /*
         if(Input.GetKey(KeyCode.RightArrow))
         {

             transform.Translate(new Vector3(vel*Time.deltaTime, 0, 0));
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {

             transform.Translate(new Vector3(-vel * Time.deltaTime, 0, 0));
         }
         if (Input.GetKey(KeyCode.UpArrow))
         {

             transform.Translate(new Vector3(0, vel * Time.deltaTime, 0));
         }

         if (Input.GetKey(KeyCode.DownArrow))
         {

             transform.Translate(new Vector3(0, -vel * Time.deltaTime, 0));
         }*/
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(H * Time.deltaTime, V * Time.deltaTime  , 0));
        
    }

   // void OnCollisionEnter(Collision2D outro)
   // {
   //     if(outro.gameObject.CompareTag("madeira"))
   //     {
   //         Destroy(outro.gameObject);
   //     }
   //         
   //  }
   // void OnCollisionExit(Collision2D outro)
   // {
   //     if (outro.gameObject.CompareTag("madeira"))
   //     {
   //         Destroy(outro.gameObject);
   //     }
   //
   // }



}
