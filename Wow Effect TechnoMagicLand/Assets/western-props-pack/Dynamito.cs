using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamito : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Destroy(this.gameObject);
    }
}
