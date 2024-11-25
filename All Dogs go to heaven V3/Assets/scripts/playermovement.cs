using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playermovement : MonoBehaviour
{
    //public variables
    public float moveSpeed = 5f;
    public float turnSpeed = 700f;

    //private variables
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerMove();
    }

    void playerMove()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");
        float MoveY = Input.GetAxis("Jump");

        Vector3 moveDirection = new Vector3(MoveX, MoveY, MoveZ).normalized;

        if (moveDirection.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSpeed, 0.1f);
            transform.rotation = Quaternion.Euler(90f, Angle, 0f);
            //playerRotate();
            Vector3 moveVelocity = moveDirection * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.position + moveVelocity);
        }

    }
}
