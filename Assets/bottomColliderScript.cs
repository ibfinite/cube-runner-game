using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomColliderScript : MonoBehaviour
{
    public PlayerMovement movemement;

    private void OnCollisionEnter(Collision collision)
    {
        movemement.enabled = false;
    }
}
