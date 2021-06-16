using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpin = 0f;
    [SerializeField] float zSpin = 5f;
    [SerializeField] float ySpin = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpin, ySpin, zSpin);
            }
}
