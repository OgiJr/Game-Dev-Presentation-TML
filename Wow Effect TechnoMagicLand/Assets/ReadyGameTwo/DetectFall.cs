using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFall : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(0).gameObject.transform.parent = null;

            GameObject[] parts = GameObject.FindGameObjectsWithTag("Parts");

            foreach (GameObject part in parts)
            {
                part.AddComponent<Rigidbody>();
                part.GetComponent<Rigidbody>().AddExplosionForce(1100, new Vector3(0,1,1), 1100);
            }
        }
    }
}