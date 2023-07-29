using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RototeAroundSun : MonoBehaviour
{
    public GameObject world1;
    public GameObject world2;
    public Vector3 wortld1Rotation;
    public Vector3 wortld2Rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        world1.transform.Rotate(wortld1Rotation);
        world2.transform.Rotate(wortld2Rotation);
    }
}
