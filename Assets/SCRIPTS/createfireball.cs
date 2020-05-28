using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createfireball : MonoBehaviour
{
    public GameObject balls;
    public GameObject mouth;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Instantiate(balls, new Vector3(mouth.transform.position.x, mouth.transform.position.y, mouth.transform.position.z), mouth.transform.rotation);
        }
    }
}
