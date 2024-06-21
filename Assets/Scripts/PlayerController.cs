using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 15f;
    public float force = 15f;
    public float rotationSpeed = 1f;
    private Rigidbody rb;
    private bool isJumping = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");// ad
        float vertical = Input.GetAxis("Vertical");//ws
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.position += transform.forward * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            isJumping = true;
        }
    }
}
