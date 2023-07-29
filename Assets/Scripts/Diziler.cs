using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diziler : MonoBehaviour
{
    float[] liste = { 1f, 2f, 5f, 7f };

    
    // Start is called before the first frame update
    void Start()
    {
        //liste[0] = 22.4f;
        //string listeString = "";
        //foreach (float eleman in liste)
        //{
        //    listeString += " " + eleman;

        //}
        //print(listeString);



        
        ArrayList benimListem = new ArrayList();
        benimListem.Add(22);
        benimListem.Add(33);
        benimListem.Add(900);


        foreach (int eleman in benimListem)
        {
            print(eleman);
        }






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
