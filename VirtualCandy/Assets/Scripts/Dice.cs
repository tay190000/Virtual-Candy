using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    static Rigidbody rigidBody;
    public static Vector3 diceVelocity;
    private bool jumpKeyPressed;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rigidBody.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyPressed = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isGrounded)
        {
            return;
        }

        if (jumpKeyPressed)
        {
            DiceText.diceNumber = 0;
            float dirX = Random.Range(0, 300);
            float dirY = Random.Range(0, 300);
            float dirZ = Random.Range(0, 300);

            rigidBody.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            rigidBody.AddTorque(dirX, dirY, dirZ);

            jumpKeyPressed = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
