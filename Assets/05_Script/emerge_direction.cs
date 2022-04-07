using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emerge_direction: MonoBehaviour
{
    public GameObject 消失物體;
    public GameObject 出現物體;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.W))
        {
            消失物體.SetActive(false);
            出現物體.SetActive(true);

        }
        if (Input.GetKey(KeyCode.S))
        {
            消失物體.SetActive(true);
            出現物體.SetActive(false);

        }
        if (Input.GetKey(KeyCode.D))
        {
            消失物體.SetActive(false);
            出現物體.SetActive(true);

        }
        if (Input.GetKey(KeyCode.A))
        {
            消失物體.SetActive(true);
            出現物體.SetActive(false);

        }
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
