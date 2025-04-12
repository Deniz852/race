using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public RoutePoint route;
    public Stopwath timer;
    private void OnTriggerEnter(Collider other)
    {
        if (route.isActive)
        {
            if (other.tag == "Player") timer.hasFinished = true;
        }
    }
}
