using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CamaraControl : PlayerControl
{
    Transform Cam;

    [SerializeField]
    GameObject Camara;

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
        Cam = transform.GetChild(0);
        Camara = GameObject.Find("Cam");

        if (Camara == null)
            Camara = null;

    }

    private void Update()
    {
        (float x, float y) = base.UpdataLook();


        Camara.transform.LookAt(transform.position);
        LookAroud(x,y);
    }


    void LookAroud(float x ,float y)
    {
        Vector2 mouseDelta = new Vector2(x,y);
        Vector3 camAngle = Cam.rotation.eulerAngles;
        float xx = camAngle.x - mouseDelta.y;

        if (xx < 180f)
            xx = Mathf.Clamp(xx, -1f, 89f);
        else
            xx = Mathf.Clamp(xx, 335f, 361f);
        Cam.localRotation = Quaternion.Euler(xx, camAngle.y+mouseDelta.x,camAngle.z);
    }

}
