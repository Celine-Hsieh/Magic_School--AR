using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emerge_npc : MonoBehaviour
{
    public GameObject 重要物品;
    public GameObject 你成功破關了;
    public GameObject npc初始介面;

    private void OnTriggerEnter(Collider other)
    {

        if (重要物品.active)
        {
            npc初始介面.SetActive(true);
        }
        else
            你成功破關了.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {
       
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
