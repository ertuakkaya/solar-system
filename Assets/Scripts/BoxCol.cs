using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCol : MonoBehaviour
{
    


    void Start()
    {
        print(GetComponent<BoxCollider>().bounds.max.y);

        // `BoxCollider`'in eksenleri ile hizalanmýþ ve onu tamamen çevreleyen bir kutuyu elde et.
        print(GetComponent<BoxCollider>().bounds);

        // Kutunun en küçük noktasýný yazdýr.
        print(GetComponent<BoxCollider>().bounds.min);

        // Kutunun en büyük noktasýný yazdýr.
        print(GetComponent<BoxCollider>().bounds.max);

        // Kutunun boyutunu yazdýr.
        print(GetComponent<BoxCollider>().bounds.size);

        // Kutunun merkezini yazdýr.
        print(GetComponent<BoxCollider>().bounds.center);
    }



}

   

