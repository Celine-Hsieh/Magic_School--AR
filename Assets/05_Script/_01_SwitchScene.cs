using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _01_SwitchScene : MonoBehaviour
{

    public void 到s02場景()
    {
        SceneManager.LoadScene("s02");
    }
    public void 到s01場景()
    {
        SceneManager.LoadScene("s01");
    }


    void Update()
    {
        
    }
}
