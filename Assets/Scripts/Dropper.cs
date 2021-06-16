using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float waitTime = 5f;
    MeshRenderer renderer;
    Rigidbody rigid;
    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
        renderer.enabled = false;
        
    }
    private void Update()
    {
        if (Time.time > waitTime)
        {
            rigid.useGravity = true;
            renderer.enabled = true;
            //      GetComponent<Rigidbody.
          //  Debug.Log(Time.time);
        }
    }
}
