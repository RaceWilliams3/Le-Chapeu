using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatPickup : MonoBehaviour
{
    void OnCollisionEnter (Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this);
        }

    }
}
