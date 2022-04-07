using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _T01_RayCtl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray 射線 = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit 擊中的目標;

        if (Input.GetMouseButtonDown(0) && Physics.Raycast(射線, out 擊中的目標)) //當滑鼠左鍵點擊且射線射到物件時，     
        {
            if (擊中的目標.transform.name == "酒瓶")//當擊中的目標名字叫酒瓶，執行下面動作
            {
                Destroy(擊中的目標.transform.gameObject);//刪除物件
            }
        }
    }

}
