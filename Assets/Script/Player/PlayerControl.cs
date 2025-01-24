using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    protected CharacterController controller;


    public virtual void Setup()
    {
        controller = GetComponent<CharacterController>();
    }
    protected virtual (float, float) UpdateMove()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        return (x, z);
    }
    protected virtual (float, float) UpdataLook()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        return (x, y);
    }

}
