using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraKontrol : MonoBehaviour
{
    public GameObject top;
    public Vector3 aradakiFark;


    // Start is called before the first frame update
    void Start()
    {
        aradakiFark = transform.position - top.transform.position;


    }

    // Update is called once per frame
    //kamera islemlerinde late update fonksıyonu kullanılr
    // update fonksıyonlarından daha sonra kullanılır
    void LateUpdate()
    {
        transform.position = top.transform.position + aradakiFark;


    }
}
