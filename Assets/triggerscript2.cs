using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered Ltrigger ");
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in Ltrigger");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left Ltrigger");
    }
}
