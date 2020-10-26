using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationblades : MonoBehaviour
{
    [SerializeField]
    public static float bladeSpeed = 50f; 

    // Update is called once per frame
    void Update()
    {
        Vector3 _rotation = new Vector3(0f, 1f, 0f) * bladeSpeed;


        PerformRotation(_rotation);
    }



    private void PerformRotation(Vector3 rotation)
    {
        transform.rotation = transform.rotation * Quaternion.Euler(rotation);
       
    }

}
