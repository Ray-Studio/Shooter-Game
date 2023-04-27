using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDrag()
    {
        if (GameObject.Find("Player").transform.position.x > -2.13f)
        {
            GameObject.Find("Player").transform.position -= new Vector3(.07f, 0, 0);
        }
    }
}