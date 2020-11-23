using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    void Start()
    {
        var childs = transform.GetComponentsInChildren<Transform>();
        foreach(Transform t in childs)
        {
            if(t.tag == "Balloon" || t.tag == "Bomb")
            {
                t.GetComponent<Rigidbody>().AddForce(Vector3.right * Random.Range(-2.0f,2.0f));
            }        
        }
    }

    void Update()
    {
        
    }
}
