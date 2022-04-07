using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class twoturn_Appear : MonoBehaviour
{

    public GameObject total2_看見地形1; 
    public GameObject total2_看見背景1;
    public GameObject total2_看見地形2;
    public GameObject total2_看見背景2;
    public Skybox 背景1;

    private void OnTriggerEnter(Collider other)
    {

        total2_看見地形1.SetActive(true);
        



    }

    private void OnTriggerStay(Collider other)
    {
        
        StartCoroutine(兩者輪流());
        
        
        


    }



   





    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {

    }



        IEnumerator 兩者輪流()
        {
      
        if (total2_看見地形1.active)
        
        {
            total2_看見地形1.SetActive(true);
            total2_看見背景1.SetActive(true);
            
            yield return new WaitForSeconds(1);
            total2_看見地形1.SetActive(false);
            total2_看見背景1.SetActive(false);

            total2_看見地形2.SetActive(true);
            total2_看見背景2.SetActive(true);
            yield return new WaitForSeconds(2);
            total2_看見地形2.SetActive(false);
            total2_看見背景2.SetActive(false);

            total2_看見地形1.SetActive(true);
            total2_看見背景1.SetActive(true);
        }

        }

  
}
