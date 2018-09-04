using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeRed : MonoBehaviour
{
    internal Material material;

    private void Start()
    {
        material = this.gameObject.GetComponent<Renderer>().material;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            material.color = Color.red;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            material.color = Color.blue;
        }
    }
}