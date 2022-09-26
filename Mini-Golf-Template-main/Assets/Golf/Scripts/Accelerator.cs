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

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
            other.gameObject.GetComponent<Rigidbody>().AddAcceleration(10000, 0, 0);
        }
    }
}
