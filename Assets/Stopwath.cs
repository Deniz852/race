using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stopwath : MonoBehaviour
{
    public bool hasFinished;
    float m;
    float s;
    public TextMeshProUGUI text;
    void Update()
    {
        if (!hasFinished)
        {
            s += Time.deltaTime;
            if (s >= 60)
            {
                m++;
                s -= 60;
            }
        }
        int mi = Mathf.RoundToInt(m);
        int se = Mathf.RoundToInt(s);
        text.text = mi + ":" + se;
    }
}
