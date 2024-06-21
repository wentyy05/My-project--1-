using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotateSpeed = 5f;
   
    // Update is called once per frame
    void Update()
    {
        float input = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, input, 0));
    }
}
