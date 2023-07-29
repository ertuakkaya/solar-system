using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intensity : MonoBehaviour
{
    //public GameObject kup;



    public Light light;

    
    // Start is called before the first frame update
    void Start()
    {
        //kup.GetComponent<Light>().intensity = 1.0f;

        //light = this.GetComponent<Light>();
        light.intensity = 2;

        
    }

    // Update is called once per frame
    void Update()
    {
        //kup.GetComponent<Light>().intensity = GetComponent<Degisken>().intensityDegeri;
        //GetComponent<Degisken>().DegerGoster();
    }
}
