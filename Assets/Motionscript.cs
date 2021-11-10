using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motionscript : MonoBehaviour
{
    public float scaler;

    Rigidbody2D rb;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float inX = scaler * Input.GetAxis("Horizontal");
        transform.position += new Vector3(inX, 0, 0);
    }
}
