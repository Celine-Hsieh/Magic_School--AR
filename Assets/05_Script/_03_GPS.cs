using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _03_GPS : MonoBehaviour
{
    public ArtRice_GPS GPS訊號;
    public Text 經度資訊;
    public Text 緯度資訊;
    public Text 虛擬起點;
    public Text 模擬座標;
    public GameObject 玩家;
    public GameObject 地圖;
    // Start is called before the first frame update
    void Start()
    {
        GPS訊號.StartPos = new Vector3(-73031, 0, -169171.4f);
    }

    // Update is called once per frame
    void Update()
    {
        地圖.transform.position = Vector3.zero - GPS訊號.NavLocalPos; 
        經度資訊.text = "經度 = " + GPS訊號.Longitude;
        緯度資訊.text = "緯度 = " + GPS訊號.Longitude;
        虛擬起點.text = "起點 = " + GPS訊號.SimLocalPos;
        模擬座標.text = "座標 = " + GPS訊號.NavLocalPos;

        //玩家.transform.position = GPS訊號.NavLocalPos;
    }
}
