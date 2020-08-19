using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
   
   private float rand;
    
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        rand = Random.Range(200.0f,250.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if(gameObject.tag == "Red" &&i==100){
             gameObject.SetActive(false);
        }
        
        if(gameObject.tag == "Blue" &&i>=rand){
           rend.enabled = false;
        }

        Debug.Log(gameObject.name+": "+i);
        ++i;

       
    }
}
