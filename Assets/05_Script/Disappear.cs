using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Disappear : MonoBehaviour
{
    
    public GameObject 消失地形1;
    public GameObject 消失地形2;
    public GameObject 消失地形3;




    private void OnTriggerEnter(Collider other)
    {
        if (消失地形1 == null) return;
        消失地形1.SetActive(false);
        if (消失地形2 == null) return;
        消失地形2.SetActive(false);
        if (消失地形3 == null) return;
        消失地形3.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        if(消失地形1 == null) return;
        消失地形1.SetActive(false);
        if (消失地形2 == null) return;
        消失地形2.SetActive(false);
        if (消失地形3 == null) return;
        消失地形3.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        if (消失地形1 == null) return;
        消失地形1.SetActive(false);
        if (消失地形2 == null) return;
        消失地形2.SetActive(false);
        if (消失地形3 == null) return;
        消失地形3.SetActive(false);
    }



    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
