using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCol : MonoBehaviour
{
    


    void Start()
    {
        print(GetComponent<BoxCollider>().bounds.max.y);

        // `BoxCollider`'in eksenleri ile hizalanm�� ve onu tamamen �evreleyen bir kutuyu elde et.
        print(GetComponent<BoxCollider>().bounds);

        // Kutunun en k���k noktas�n� yazd�r.
        print(GetComponent<BoxCollider>().bounds.min);

        // Kutunun en b�y�k noktas�n� yazd�r.
        print(GetComponent<BoxCollider>().bounds.max);

        // Kutunun boyutunu yazd�r.
        print(GetComponent<BoxCollider>().bounds.size);

        // Kutunun merkezini yazd�r.
        print(GetComponent<BoxCollider>().bounds.center);
    }



}

   

