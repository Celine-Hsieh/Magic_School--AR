using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUTTON : MonoBehaviour
{
    public GameObject 道具欄;
    public GameObject 武器;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.X))
        {
            道具欄.SetActive(true);
             
        }

        else if(Input.GetKeyUp(KeyCode.C))
        {
            道具欄.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            武器.SetActive(true);

        }
    }
}