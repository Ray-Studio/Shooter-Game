using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TolidEnemy : MonoBehaviour
{

    public float Zaman;
    public GameObject Prefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Zaman += 1 * Time.deltaTime;
        if (Zaman >= 3)
        {
            Instantiate(Prefab, transform.position = new Vector3(Random.Range(-1.9f, +1.9f), transform.position.y, 0), Quaternion.identity);
            Zaman = 0;
        }
    }
}