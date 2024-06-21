using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turner : MonoBehaviour
{
    public int direction = 1;
    private float turnAngel = - 90f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out _))
        {
            other.gameObject.transform.Rotate(other.gameObject.transform.up, turnAngel * direction);
        }
    }
}
