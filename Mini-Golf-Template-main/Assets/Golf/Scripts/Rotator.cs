using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Transform Rotor;
    float timeLeft = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Rotor.Rotate(1f, 0.0f, 0.0f, Space.Self);
            timeLeft = .01f;
        }

    }
}
