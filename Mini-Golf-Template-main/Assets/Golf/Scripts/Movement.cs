using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.03f;
    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (time > 5) {
            transform.position = transform.position + new Vector3(Input.GetAxis("Vertical") * speed, 0, Input.GetAxis("Horizontal") * speed);
            time = 0;
        }
        
        time +=1;
    }
}
