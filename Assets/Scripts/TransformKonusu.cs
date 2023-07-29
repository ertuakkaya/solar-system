using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformKonusu : MonoBehaviour
{
    public Vector3 yon;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Transform>().Translate(yon);
        //GetComponent<Transform>().Rotate(yon);
        transform.Translate(yon);
        //transform.Rotate(yon);
        
    }
}
