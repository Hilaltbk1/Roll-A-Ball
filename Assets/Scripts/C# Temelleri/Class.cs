using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Araba araba1 = new Araba();
        araba1.marka = "BMW";
        araba1.model = "xs";
        araba1.fiyat = 5000000;



        // class / bu clastan turettıgımız obje
        //Araba adlı scrıpt classımızdan bır obje turettık
        //birden fazla obje turetebiliyoruz
        //Araba araba2 = new Araba();
         print(araba1.marka);
        // Gerekli kosulları sagladıgımızda araba adlı scrıpt dosyamızdakı bır 
        //bilgiye buradan erıstık
         print(araba1.model);
         print(araba1.fiyat);

        // print("Araba 2 nin ozellikleri : ");
        // print(araba2.model);
        // print(araba2.marka);
        //print(araba2.fiyat);

        // araba1.arabaSurmek();
        Araba araba2 = new Araba();
        araba2.marka = "honda";
        araba2.model = "civic";
        araba2.fiyat = 20000;

        print(araba1.marka);
        print(araba1.model);
        print(araba1.fiyat);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
