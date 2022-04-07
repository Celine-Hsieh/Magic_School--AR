using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _03_save : MonoBehaviour
{

    public InputField 輸入框InputField;
    public Text 顯示文字Text;
    public string 玩家名稱;

    // Start is called before the first frame update
    void Start()
    {
        顯示文字Text.text = PlayerPrefs.GetString("儲存_玩家名稱");  //抓取當前資料
    }

    public void 存檔()
    {
        玩家名稱 = 輸入框InputField.text;
        PlayerPrefs.SetString("儲存_玩家名稱", 玩家名稱);  //儲存資料
        顯示文字Text.text = PlayerPrefs.GetString("儲存_玩家名稱");  //顯示資料
        輸入框InputField.text = null;

    }

    public void 移除資料()
    {
        //PlayerPrefs.DeleteAll();  //刪除資料
        PlayerPrefs.DeleteKey("儲存_玩家名稱");
        顯示文字Text.text = PlayerPrefs.GetString("儲存_玩家名稱");  //顯示資料
    }
}
