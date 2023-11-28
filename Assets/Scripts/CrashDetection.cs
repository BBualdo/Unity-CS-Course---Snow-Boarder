using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Debug.Log("Ouch, I fall on my head!");
        }
    }
}
