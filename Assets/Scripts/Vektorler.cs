using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vektorler : MonoBehaviour
{

    public Vector2 vec;
    public Vector2 vec1;
    public Vector2 vec2;

    void Start()
    {
        vec.x = 2;
        vec.y = 4;

        vec = new Vector2(3, 4);
        vec1 = new Vector2(5, 6);
        vec2 = vec + vec1;
        print("Vektorlerin topalmi =  " + vec2);

    }


    void Update()
    {
        
    }
}
