using UnityEngine;

public class MoveControl : PlayerControl
{
    [SerializeField]
    [Range(0,100)]
    private float moveSpeed;
    private Vector3 MoveForce;

    private void Awake()
    {
        base.Setup();
    }

    // Update is called once per frame
    void Update()
    {
        (float x, float z) = base.UpdateMove();
        MoveTo(new Vector3(x,0,z));
        controller.Move(MoveForce*Time.deltaTime);
    }
    public void MoveTo(Vector3 direction)
    {
        direction = transform.rotation * new Vector3(direction.x, 0, direction.z);

        MoveForce =new Vector3(direction.x*moveSpeed,MoveForce.y, direction.z*moveSpeed);
    }
}
