using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour
{
    bool hasPackage;
    float Packagevanish = 0.5f;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package Received");
            hasPackage = true;
            Destroy(other.gameObject, Packagevanish);


        }

        if (other.tag == "Customer")
        {
            if (hasPackage == true)
            {
                Debug.Log("Package Delivered");
                hasPackage = false;
            }
        }
    }
}

