using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DectectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Debug.Log("Game Over");
    }
}
