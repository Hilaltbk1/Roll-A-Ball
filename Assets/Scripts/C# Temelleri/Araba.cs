using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araba : MonoBehaviour
    //public yerine private yapsaydık eger hata verırdı cunku prıvate ozel anlamı tasır
    // baska scrıpt dosyalarından erısılemez
    //private ya da publıc yazarak bu dosyalara baska scrıpt dosyalarından erısılıp erısıl
    //meyecegini denetleyebiliyoruz

{
    //Araba aslinda bir classtır
    //buradakı publıclerı prıvate yapıp baska scrıpten erısmeye calısırdakta hata verır
    //string bir deger tanımlayıp bır deger atamazzak
    //null degerını verır int bir deger tanımlayıp bır deger atamazzak
    //0 degerini verir
    public string marka ;
    public string model ;
    public int fiyat ;
    //classımıza bır metotda yazıp obur scrıpten onu da cagırabılırız
    public void arabaSurmek()
    {
        print("Araba sürülüyor !");
    }


}
