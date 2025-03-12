using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CamaraControl : PlayerControl
{
    Transform Cam;

    [SerializeField]
    [Range(0,20)]
    private float rotCamXaxisSpeed;

    [SerializeField]
    [Range(0, 20)]
    private float rotCamYaxisSpeed;

    [SerializeField]
    [Range(-100,100)]
    private float IimitMinX;
    [SerializeField]
    [Range(-100, 100)]
    private float IimitMaxX;


    private float eulerAngleX;
    private float eulerAngleY;

    private void Awake()
    {
    }

    private void Update()
    {
        (float x, float y) = base.UpdataLook();



    }



}
