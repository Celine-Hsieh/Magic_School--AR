using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class threeturn_Appear : MonoBehaviour
{

    
    public GameObject total3_看見地形1;
    public GameObject total3_看見背景1;

    public GameObject total3_看見地形2;
    public GameObject total3_看見背景2;

    public GameObject total3_看見地形3;
    public GameObject total3_看見背景3;



    private void OnTriggerStay(Collider other)
    {
        
       

        StartCoroutine(三者輪流());

    }



   

  
   

   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }




    IEnumerator 三者輪流()
    {

        if (total3_看見地形1.active)

        {
            total3_看見背景1.SetActive(true);
            total3_看見地形1.SetActive(true);
           

            yield return new WaitForSeconds(2);
            total3_看見地形1.SetActive(false);
            total3_看見背景1.SetActive(false);


            total3_看見背景2.SetActive(true);
            total3_看見地形2.SetActive(true);
           
            yield return new WaitForSeconds(5);
            total3_看見地形2.SetActive(false);
            total3_看見背景2.SetActive(false);

           
            total3_看見背景3.SetActive(true);
             total3_看見地形3.SetActive(true);
           yield return new WaitForSeconds(5);
            total3_看見地形3.SetActive(false);
            total3_看見背景3.SetActive(false);
            
            total3_看見背景1.SetActive(true);
            total3_看見地形1.SetActive(true);
            
        }

    }
}
