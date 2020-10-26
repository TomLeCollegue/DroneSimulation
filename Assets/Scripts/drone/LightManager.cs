using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public GameObject Light1;
    public GameObject Light2;

    
    void Start()
    {
        InvokeRepeating("ActiveLight", 0, 0.5f);
    }


    void ActiveLight()
    {
        if (Light1.activeSelf)
        {
            Light1.SetActive(false);
            Light2.SetActive(false);
        }
        else
        {
            Light1.SetActive(true);
            Light2.SetActive(true);
        }
    }
}
