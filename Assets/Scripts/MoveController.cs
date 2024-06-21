using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private static string[] lines = { "left", "mid", "right" };
    public float lineOffSet = 85f;
    public float speed = 100f;
    private int currentLineIndex = lines.Length / 2;
    private new Rigidbody rigidbody;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Move()
    {
        rigidbody.velocity = transform.forward * speed;
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            horizontalInput = 1;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            horizontalInput = -1;
        }
        else
        {
            horizontalInput = 0;
        }
       
        if (horizontalInput != 0)
        {
            if (currentLineIndex == 0 && horizontalInput < 0)
            {
                return;
            }
            if (currentLineIndex == lines.Length - 1 && horizontalInput > 0)
            {
                return;
            }
        }
        transform.position += horizontalInput * lineOffSet * transform.right;
        currentLineIndex += (int)horizontalInput;
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
        HandleInput();
    }
}
