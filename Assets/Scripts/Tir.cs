using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{

    public float Zaman;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, .04f, 0);

        Zaman += 1 * Time.deltaTime;
        if (Zaman >= 3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}