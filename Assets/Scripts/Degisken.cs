using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Degisken : MonoBehaviour
{
    public int intensityDegeri;
    
    // Start is called before the first frame update
    void Start()
    {
        intensityDegeri = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DegerGoster()
    {
        print("Deger =  " + intensityDegeri);
    }

}
