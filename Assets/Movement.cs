using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector3 moveAmount = new();


        if (Input.GetKey(KeyCode.W))
        {
            moveAmount.z += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveAmount.z += -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveAmount.x += 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveAmount.x += -1;
        }

        print(moveAmount);
        moveAmount.Normalize();
        print(moveAmount);

        transform.position += moveAmount * (speed * Time.deltaTime);
    }
}