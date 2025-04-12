using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutePoint : MonoBehaviour
{
    public RoutePoint routePoint;
    public GameObject model;
    public bool isActive;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(isActive)
            {
                isActive = false;
                model.SetActive(false);
                if(routePoint != null)
                {
                    routePoint.isActive = true;
                    routePoint.model.SetActive(true);
                }
            }
        }
    }
}
