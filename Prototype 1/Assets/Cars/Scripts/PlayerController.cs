using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public WheelCollider frontDriverW, frontPassengerW;
    public WheelCollider rearDriverW, rearPassengerW;
    public Transform frontDriverT, frontPassengerT;
    public Transform rearDriverT, rearPassengerT;
    public float maxSteerAngle = 30;
    public float motorForce = 50;
    public float brakeForce;
    public float maxSpeed;
    public float currentSpeed;
    public float m_Downforce = 100f;
    public Texture normalTexture;
    public Texture brakingTexture;
    public Renderer carRenderer;

    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;
    private bool isBraking = false;

    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
        isBraking = Input.GetKey(KeyCode.Space);
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        frontDriverW.steerAngle = m_steeringAngle;
        frontPassengerW.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        currentSpeed = 2 * Mathf.PI * frontDriverW.radius * frontDriverW.rpm * 60 / 1000;
        frontDriverW.motorTorque = m_verticalInput * motorForce;
        frontPassengerW.motorTorque = m_verticalInput * motorForce;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontDriverW, frontDriverT);
        UpdateWheelPose(frontPassengerW, frontPassengerT);
        UpdateWheelPose(rearDriverW, rearDriverT);
        UpdateWheelPose(rearPassengerW, rearPassengerT);
    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);

        _transform.position = _pos;
        _transform.rotation = _quat;
    }
    private void Braking()
    {
        if (isBraking)
        {
            frontDriverW.brakeTorque = brakeForce;
            frontPassengerW.brakeTorque = brakeForce;
            rearDriverW.brakeTorque = brakeForce;
            rearPassengerW.brakeTorque = brakeForce;

            carRenderer.material.mainTexture = brakingTexture;
        }
        else
        {
            frontDriverW.brakeTorque = 0;
            frontPassengerW.brakeTorque = 0;
            rearDriverW.brakeTorque = 0;
            rearPassengerW.brakeTorque = 0;

            carRenderer.material.mainTexture = normalTexture;
        }
    }
    // this is used to add more grip in relation to speed
    private void AddDownForce()
    {
        frontDriverW.attachedRigidbody.AddForce(-transform.up * m_Downforce *
                                                     frontDriverW.attachedRigidbody.velocity.magnitude);
        frontPassengerW.attachedRigidbody.AddForce(-transform.up * m_Downforce *
                                                     frontPassengerW.attachedRigidbody.velocity.magnitude);
        rearDriverW.attachedRigidbody.AddForce(-transform.up * m_Downforce *
                                                     rearDriverW.attachedRigidbody.velocity.magnitude);
        rearPassengerW.attachedRigidbody.AddForce(-transform.up * m_Downforce *
                                                     rearPassengerW.attachedRigidbody.velocity.magnitude);
    }
    public void Start()
    {
    }
    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        AddDownForce();
        Braking();
        UpdateWheelPoses();
    }
}
