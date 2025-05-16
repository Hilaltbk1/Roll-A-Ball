using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//UI paketi dahil edildiginde textlerdeki hata gider

public class TopKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    //Start metotu update metodundaki ilk frame başlatılmadan once okunur (cagrılır, islenir ,calıstırılır)
    public Rigidbody fizik; // obje turettım ama ne oldugunu ıfade etmem gerekıyor
    public int hiz;
    public int puan;
    public int objeSayisi;
    public Text puanText;
    public Text OyunBittiText;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        // get companentle bır objenın ne oldugunu belırtebılıyoruz 
            //topumu hareket ettırmeye saglayan bir metottur
            //transform inspectordeki transforma isaret eder ( vektor 3 ister )
    }

    // Update is called once per frame
    // voıd fıxedupdate hazır fonksıyonlardan bırısıdir 
    //genelde fizik olaylarında kullanılır
    void FixedUpdate()
    {
        //transform.Translate(0, 0, 0.1f);
        // transform.Rotate(0, 0, 0.1f);  donus

        //inputla klavyeen yapılan girdileri denetlerız
        //getkeydown metotuna parametre olarak keycode atadık 
        //yazdıgımız kod esc tusuna basılıp basılmadıgını kontrol edecek (esc tusuna basarsa true dondurcek)
        //debug.lof kullanılır genelde print yerıne
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Debug.Log("Esc tusuna basıldı !!");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            Debug.Log("E tusuna basıldı !!");
        } */
        //yatay eksendekı tusları kontrol etmek için ozel bir metot var

       float yatay =  Input.GetAxis("Horizontal");
        //konsolda nasıl bır deger dondurecegını gormek için yatay olarak bir degiskene atadık
       // Debug.Log("yatay =" + yatay);
        //ayni sey dikey olarak yapmak içinde 
        float dikey = Input.GetAxis("Vertical");
        // Debug.Log("dikey = " + dikey);
        Vector3 vektor = new Vector3(yatay, 0, dikey);


        fizik.AddForce(vektor*hiz);
        //fizik adlı rıgıtboy e add force metotu uygulayarak bir kuvvet uygulayacagız
       // Debug.Log(transform.position);

    }
     void OnTriggerEnter(Collider other)
    {
        //collider classımızdan bır obje turetılmıs other adında
        //on trogger metotu oyunumuzdakı trıggerın tetıklenıp tetıklenmedıgını denetler
        //trigger acıksa ıcınden gercer collider acık olsa bıle
        //collider kapalı oldugunda cısmın sınırlarını unıty algılamaz
        //colliderin turkcesı carpısma demek
        //bir carpısma oldugu anda bu metot tetıklenır
        //Debug.Log("Çarpısma oldu !");

        // Destroy(other.gameObject);
        //Her carpısma oldugunda other carptıgımız kube esıtlenıyor
        //boyle bırakırsak bır islem gerceklesmez cunku otherın bır game obje oldugunu belirtmedik 
        //belirtmeliyizkı carptıgı nesnenın bır game obje odugunu algılyıp onu yoketsın
        //Bu metotta yok edıp tekrar varetme islemi oldugu ıcın yok fazla ram ı yorar bu yuzden farklı bır metot kullanacagız
        //genelde objeler yok edılıp tekrar kullanılacaksa set actıve ozellıgınden yararlanırız
        other.gameObject.SetActive(false);
        puan += 1;
        //puan =puan+1 ile puan++ ve usttekı aynı anlam
        // Debug.Log("Sayac= " + puan);
        puanText.text = "PUAN : " + puan;
        if (puan== objeSayisi)
        {
            // Debug.Log("Oyun bitti !!!");

            OyunBittiText.gameObject.SetActive(true);
        }
        //Oyunu buildd etmek : Oyunu herhangı bır platformda yayınlamak











    }
    /*
     void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false);
        bu metottda topumuz objelerle temas ettıgı anda degılde temasının kesıldıgı anda objemız yokolur
    }

    
    private void OnTriggerStay(Collider other)
    {
        other.gameObject.SetActive(false);
        bu metotda topumuz objenın ıcınde kaldıgı zaman objemız  yokolur
    }
    */

    //textin dısındakı beyaz cızgılı alan canvastır ve eventsystem ise text ın hem pc hemde mobıl cıhazlarla uyumlu olmasını saglıyor






}
