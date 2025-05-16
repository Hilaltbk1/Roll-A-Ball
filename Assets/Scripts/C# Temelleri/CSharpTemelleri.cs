using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpTemelleri : MonoBehaviour
{
    // Start is called before the first frame update
    //Start metotu update metodundaki ilk frame başlatılmadan once okunur (cagrılır, islenir ,calıstırılır)
    void Start()
    {    //integer: tam sayilari yazdırmak için kullanılırz
         // print(2);
        /* int x = 17;
         print(x); */


        //float :virgullu sayıları yazdırmak için kullanırız (nokto kullanılır)
        // print(3.14);
        /* float y= 17.5f; // Float deger atarken f eklenir sonuna
         print(y); */


        //string ile insanlarin anlayabilecegi seyleri yazdırabiliriz
        // print("hello world");
        /* string ad = " hilal tbk";
        print(ad); */


        //Degisken atama

        /* string isim = "hilal tabak";
         print(isim);
         print(isim);
        */
        // var :tum veri tıplerinde kullanabılırız
        /*
        var a = 15;
        var b = 15.5f;
        var c = " hilal";

        print(a);
        print(b);
        print(c); */
        // Matematiksel operatorler (4 temel işlem) ontanımlı olarak gelır yanı bizim bir sey ogretmemiz gerekmez
        //print(1 + 5);

        //bool : iki deger alablir ya true ya false 
        /* bool x = true;
         print(x); */
        /*
        var x = "1";
        var y = "2";
        print(x + y); 
        
        var x = 1;
        var y = 2;
        print(x + y);
        
        var a = "hilal";
        var b = " tabak";
        print(a + b); 
        
        var a= "123";
        var b = "456";
       print(a + b); 

        var a = "hilal";
        var b = 12;
        var c = 3.14f;
        print(a + " " + b + " " + c); */
        // karsilastirma operatorleri 
        /* >  büyüktür
           < kücüktür
           == esittir   ( tek esittir atama )
           >= buyuk  ya da esittir
           <= kucuk ya da esittir 
      */
        // print(6 > 5); soru anlamı tasır true ya da false verir
        // kosullu ifadeler if - else - else if 
        // else sadece if ve else if durumlarının yanlıs oldugu durumlarda ıslenir ( ilk if sonra else if en son else bloguna bakılır)
        //Kodlar yukarıdan asagıya dogru islenir 
        /*
        var a = 5;
        var b = 6;
        var c = 5;

        if (a==b) // atama degil esitlik gostergesinden dolayı ıkı esıttır
        {
            print("a b' ye esittir");
        }
        else if (b==c)
        {
            print("b c' ye esittir");
        }
        else
        {
            print("a c' ye esittir");
        }
        */
        // while dongusu 
        /*
        var x = 0;
        while (x<5)
        {
            x = x + 1;
            print(x);

        }
        //x 5'ten kücük oldugu durumlarda while kod blogu işlenir kod blogu bıtınce tekrar saglıyorsa o kosulu
        // tekrar islenir ta ki saglamayana dek
        */
        // do - while dongusu 
        /*
        var x = 0;
        do
        {
            x += 1; // x=x+1 ile aynıdır 
            print(x);

        } while (x < 5); ;
        */
        // normalde ilk while kod blogu işlenirken do-whilede ilk do blogu işlenir vw ardından while kosulu saglanıyorsa tekrar do blogu islenir
        //islem while kosulu saglanmayana dek surer
        // switc-case yapısı 
        /*
        var x = 2;
        switch (x) // x degerine bakıyoruz 
        {
            case 1:   // x'in degerinin 1 olma durumu ( sartı )  (casesi) dogruysa print calısır yanlıssa break yapıp dıger caselere gecer
                print("x'in degeri 1 'dir ");
                break; // donguden cıkmak ıcın kullanırız 
            case 2:
                print("x'in degeri 2'dir ");
                break;
        }
        // sadece 1 case durumu dogru cıkmak zorundadır if -else de ise birden fazla kod blogu dogru olursa  islenebilir
        */
        //Listeler
        /*
        List<string> gunler = new List<string>(); // gunler adında bir liste olursturduk
        // Birden fazla string degeri atayabılırız
        gunler.Add("Pazartesi ");
        gunler.Add("Salı ");
        gunler.Add("Carsamba "); */

        //print(gunler); // yaptıgımızda gunleri sairasıyla yazmaz cunku listler isterable objedir 

        //İterable Obje = icerisinde birden fazla nesne bulunduran objelere denir
        //gunler adında bir obje (nesne ) olusturduk ve icerisine birden fazla degisken atadık
        // İterable objeleri foreach ile yazdırabılıyoruz
        /*
        foreach (var item in gunler) // item dedigimiz olusturdugumuz gecıcı obje  ve bu obje olusturdugumuz obje ıcınde dolasacak ve 
                                     // ilk olarak listemizdeki ilk elemana esitlenecek sonra ıkıncısı vs

        {
            print(item);
        }
        */
        //Array 
        /*
        string[] gunler= { "pazartesi", "sali", "carbamba" };
        foreach (var item in gunler )
        {
            print(item);
        }
        */
        //Array listler
        //Farkli turdeki degiskenleri tutabilir ve sonradan ekleme yapabiliriz
        
        //ArrayList karisik = new ArrayList();

       // karisik.Add(2);
        //karisik.Add(2.14f);
        //karisik.Add("hilal");
        /*
        foreach (var item in karisik)
        {
            print(item);
        }
        */
       // print(karisik[1]);















    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
