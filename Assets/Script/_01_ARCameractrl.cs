using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _01_ARCameractrl : MonoBehaviour
{
    public ArtRice_Gyro 陀螺儀; //定義角色
    public Camera AR相機;
    public GameObject Cube;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cube.transform.rotation = 陀螺儀.GyroAngle;
        AR相機.transform.rotation = 陀螺儀.GyroAngle;
        Ray 射線 = AR相機.ScreenPointToRay(Input.mousePosition);
    }
}
