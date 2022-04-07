using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class _test_angle : MonoBehaviour
    
{
    public Text 座標;
    public Text 角度;
    private Quaternion _CurrentGyro;
    private Quaternion _OriginGyro;
    private Quaternion _OriginGyroInverse;
    private Vector3 _Pointer;

    // Use this for initialization
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            Debug.Log("Gyro Enabled");
            _OriginGyro = Input.gyro.attitude;
            _OriginGyroInverse = Quaternion.Inverse(_OriginGyro);
            _Pointer = Vector3.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _CurrentGyro = Input.gyro.attitude;
        _Pointer = _CurrentGyro * Vector3.forward;
        Debug.Log("The Angle of Device Rotation: " + Quaternion.Angle(_CurrentGyro, _OriginGyro));
        Debug.Log("The Device is pointing: " + _OriginGyroInverse * _Pointer);
        座標.text = "座標" + _OriginGyroInverse * _Pointer;
        角度.text = "角度" + Quaternion.Angle(_CurrentGyro, _OriginGyro);
    }
}