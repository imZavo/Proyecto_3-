using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    public Camera cam1, cam2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }

    }



}
