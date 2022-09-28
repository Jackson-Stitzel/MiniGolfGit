using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.Project(other.gameObject.GetComponent<Rigidbody>().velocity, new Vector3(-1,0,0)).magnitude * 12,0,0 , ForceMode.Acceleration);
            //this.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);


        }
    }
}
