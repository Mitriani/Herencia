using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYellow : PlayerRed
{
    private void Start()
    {
        
    }
    new protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red"))
        {
           //Debug.Log();
        }
    }
}
