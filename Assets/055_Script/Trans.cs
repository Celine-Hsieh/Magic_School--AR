using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trans : MonoBehaviour

{
    public void 到S01場景()
    {

        SceneManager.LoadScene("_01SCENE");
    }

    public void 到S01_1場景()
    {

        SceneManager.LoadScene("_01_SCENE");
    }

    public void 到S02場景()
    {

        SceneManager.LoadScene("_02SCENE");
    }

    public void 到S03場景()
    {

        SceneManager.LoadScene("_03SCENE");
    }

    public void 到S04場景()
    {

        SceneManager.LoadScene("_04SCENE");
    }
    public void 到S05場景()
    {

        SceneManager.LoadScene("_05SCENE");

       
    }
    public void 到遊戲主場景()
    {

        SceneManager.LoadScene("背包");
    }
    public void 到AR()
    {
        SceneManager.LoadScene("AR");
    }
}


