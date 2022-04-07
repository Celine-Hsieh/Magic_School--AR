using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _02_ARCameraCtl : MonoBehaviour
{
    public ArtRice_Gyro 陀螺儀;
    public Camera AR相機;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AR相機.transform.rotation = 陀螺儀.GyroAngle;
        //print(陀螺儀.GyroAngle);

        Ray 射線 = AR相機.ScreenPointToRay(Input.mousePosition);
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
