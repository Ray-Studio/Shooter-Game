using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirZadan : MonoBehaviour
{

    public GameObject Prefab;


    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Instantiate(Prefab, GameObject.Find("Tofang").transform.position, Quaternion.identity);
    }
}