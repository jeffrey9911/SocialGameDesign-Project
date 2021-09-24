using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMushroom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime, Space.Self);
        }

    }
}
