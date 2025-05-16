using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetotKonusu : MonoBehaviour
{
    //  Void fonksıyonundan cıkan degerlerı baska fonksıyonlara deger olarak veremıyoruz 
    //Void olmayan fonksıyonlardan cıkan degerlerı baska fonksıyonlara deger olarak verebiliyoruz
    // Start is called before the first frame update
    void Start()
    {
        //print(5 + 3);
        // her seferinde bir suru toplama yapmak yerıne bır toplama methodu kurup daha kolay yapabılırız
        // topla(16,50); // degerlerı atadık
        //AdSoyad("hilal","tabak");
        //AdSoyad("hi", "barbie");
        //cikar(topla(5, 3));
        //print(Ad("hilal"));
    }
    /*
    void AdSoyad(string isim,string soyisim)
    {
        print(isim + soyisim);
    }
        
    string  Ad(string isim)
    {
        return isim;
    } */
  /* void cikar(int sayi)
    {
        print(sayi - 5);
    }
  */
   /* int topla(int x,int y )
    {
        //on tanımlı bır metot olmadıgından dolayı ne yapması gerektıgını belirlemeliyiz

       // return x + y ; // yapmasını ısledıgımız işlemi yazdık
        // void olmadıgı ıcın return kullanıyoruz (deger dondurmesı ıcın )
        //return ifadesi konsola bastırmaya yaramaz sadece fonksiyonun cıktı uretmesını saglar
        //bir metottun olusturulması onun calısıcagı anlamına gelmez
        //calısması ıcın cagırmalıyız
    } */
    // Update is called once per frame
    void Update()
    {
        // update metotuna yazdıgımız seyler her framede bir kez daha cagırılır 
       // print(5 + 3);  ornegın 10 -15 sn calıstıgında bıle bın kusur defa cagırlır ve o kadar  cıktı verır 
        //unitydeki collapse basarsam aynı cıktılar tek bır satır halınde gozukur
    }
}
