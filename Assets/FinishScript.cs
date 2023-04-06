using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    public LogicScript logic;

    private void OnTriggerEnter(Collider other)
    {
        logic.CompleteLevel();
    }
}
