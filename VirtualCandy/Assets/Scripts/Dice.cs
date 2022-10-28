using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    static Rigidbody rigidBody;
    public static Vector3 diceVelocity;
    public static bool isGrounded;
    public static bool rollAgain = true;
    public static bool waitForRollToFinish = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rigidBody.velocity;

    }

    private void FixedUpdate()
    {
        if (!isGrounded)
        {
            return;
        }

        if (rollAgain)
        {
            DiceText.diceNumber = 0;
            float dirX = Random.Range(0, 300);
            float dirY = Random.Range(0, 300);
            float dirZ = Random.Range(0, 300);

            rigidBody.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            rigidBody.AddTorque(dirX, dirY, dirZ);

            rollAgain = false;
            DiceBoardCheck.rolledAgain = true;
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
