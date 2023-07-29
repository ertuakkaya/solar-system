using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class RigidB : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 positionVec;
    public Vector3 hiz;
   
    

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        positionVec = new Vector3(1,1,1);
        hiz = new Vector3(1,1,1);
       

       
    }

    // Update is called once per frame
    void Update()
    {
         rb.MovePosition(positionVec);
        rb.velocity = hiz * 100;
        
        
    }
}
