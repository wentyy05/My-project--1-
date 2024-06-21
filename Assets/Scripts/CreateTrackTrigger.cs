using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTrackTrigger : MonoBehaviour
{
    public event Action Collided;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out _))
        {
            Collided?.Invoke();
        }
    }
}
