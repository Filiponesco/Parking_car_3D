using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEngine : MonoBehaviour
{
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Drive();
    }
    private void Drive()
    {
        wheelFL.motorTorque = 10000f;
        wheelFR.motorTorque = 10000f;
    }
}
