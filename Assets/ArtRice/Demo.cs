using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public ArtRice_GPS ArtRice_GPS;
    public Text Text;
    public GameObject Tatget;

    void Start()
    {

    }

    void Update()
    {
        Text.text =
            "GPS狀態：" + ArtRice_GPS.IsGPS + "\n" +
            "GPS更新速度：" + ArtRice_GPS.GPSUpdateTime + "秒\n" +
            "GPS經度：" + ArtRice_GPS.Longitude + "\n" +
            "GPS緯度：" + ArtRice_GPS.Latitude + "\n" +
            "自定義起點座標：" + ArtRice_GPS.StartPos + "\n" +
            "虛擬起點座標：" + ArtRice_GPS.SimLocalPos + "\n" +
            "導航模擬座標：" + ArtRice_GPS.NavLocalPos;

        Tatget.transform.position = ArtRice_GPS.NavLocalPos;
    }
}
