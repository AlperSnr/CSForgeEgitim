using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Odev : MonoBehaviour
{
    public float timer = 0f;

    

    void Start()
    {
        Vector3 pos = transform.position;

        float x = pos.x;

        if (x < 5)
        {
            pos.x = 0;
        }
        else
        {
            pos.x = 10;
        }

        transform.position = pos;

    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 5f)
        {
            transform.position += new Vector3(0, 0, 1 * Time.deltaTime);
        }
    }
}
