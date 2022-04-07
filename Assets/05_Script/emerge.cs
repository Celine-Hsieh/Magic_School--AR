using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emerge : MonoBehaviour
{
    public GameObject description;

    private void OnTriggerEnter(Collider other)
    {
        if (description == null) return;
        description.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (description == null) return;
        description.SetActive(false);
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
