using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeKontrol : MonoBehaviour
{
    //Prefab: Aynı nıtelıktekı objeleri tekrar tekrar olusturmak yerıne bır defa olusturup sahnede bu objeyı kullanma islemidir
    
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 vektor = new Vector3(15, 30, 45);


        transform.Rotate(vektor*0.02f);
        //bu hızlarla kuplerin donmesini sagladık
    }
}
