using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePoint : MonoBehaviour
{
    public GameObject model;
    public bool isActive;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isActive)
            {
                isActive = false;
                model.SetActive(false);
            }
        }
    }
}
