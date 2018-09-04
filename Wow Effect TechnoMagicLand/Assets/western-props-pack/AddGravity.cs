using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGravity : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;

        }
    }
}