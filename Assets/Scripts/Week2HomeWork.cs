using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class Week2HomeWork : MonoBehaviour
{

    


    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(10, 57);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void bolenleriBul(int ilkSayi , int ikinciSayi)
    {

        ArrayList dizi = new ArrayList();
        ArrayList ikiyeTam = new ArrayList();
        ArrayList uceTam = new ArrayList();
        ArrayList dordeTam = new ArrayList();
        ArrayList beseTam = new ArrayList();

        int diziUzunlugu = ikinciSayi - ilkSayi + 1 ;
        print("dizinin uzunlugu =  " + diziUzunlugu);

        
        
        print("Dizideki Tum Sayilar :  ---------------------------------------------------------");
        
        for (int i = 0; i < diziUzunlugu; i++)
        {
            
            
            dizi.Add(ilkSayi);

            if (ilkSayi % 2 == 0)
            {
                // 2'ye bolunuyor
                ikiyeTam.Add(ilkSayi);

            }
            if (ilkSayi % 3 == 0)
            {
                // 3'e bolunuyor
                uceTam.Add(ilkSayi);
            }
            if (ilkSayi % 4 == 0)
            {
                // 4'e tam bolunuyor
                dordeTam.Add(ilkSayi);
            }
            if (ilkSayi % 5 == 0)
            {
                // 5'e bolunuyor
                beseTam.Add(ilkSayi);
            }


            
            print(ilkSayi);
            ilkSayi++;
            

        }

        print(" 2'ye TAM BOLUNENLER  ------------------------------------------------------------------------" );
        foreach (var item in ikiyeTam)
        {
            print(item);
        }


        print(" 3'e TAM BOLUNENLER  ------------------------------------------------------------------------       ");
        foreach (var item in uceTam)
        {
            print(item);
        }


        print(" 4'e TAM BOLUNENLER  ------------------------------------------------------------------------       ");
        foreach (var item in dordeTam)
        {
            print(item);
        }



        print(" 5'e TAM BOLUNENLER  -----------------------------------------------------------------------       ");
        foreach (var item in beseTam)
        {
            print(item);
        }



    }


}
