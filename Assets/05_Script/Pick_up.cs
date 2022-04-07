using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_up: MonoBehaviour
{
    public GameObject 撿起按鈕;
    public GameObject 重要物品;
    public GameObject 重要物品圖片;
    public GameObject 魔丈Gun;

    private void OnTriggerEnter(Collider other)
    {
       if (撿起按鈕 == null) return;
        
            撿起按鈕.SetActive(true);
            魔丈Gun.SetActive(false);

    }

    private void OnTriggerExit(Collider other)
    {
        if (撿起按鈕 == null) return;
        撿起按鈕.SetActive(false);
        魔丈Gun.SetActive(true);

    }
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
           
    }
}