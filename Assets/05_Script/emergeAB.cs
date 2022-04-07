using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emergeAB : MonoBehaviour
{
    public GameObject 消失物體;
    public GameObject 出現物體;

    private void OnTriggerStay(Collider other)
    {

        消失物體.SetActive(false);
        出現物體.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        消失物體.SetActive(true);
        出現物體.SetActive(false);
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
