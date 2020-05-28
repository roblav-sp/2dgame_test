using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefireball : MonoBehaviour
{
    public float velo = 5.0f;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-velo * Time.deltaTime, 0));
    }
}
