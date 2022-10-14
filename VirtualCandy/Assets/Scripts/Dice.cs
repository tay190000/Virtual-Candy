using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    static Rigidbody rigidBody;
    public static Vector3 diceVelocity;

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
            DiceText.diceNumber = 0;
            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);

            transform.position = new Vector3(0, 2, 0);
            transform.rotation = Quaternion.identity;

            rigidBody.AddForce(transform.up * 500);
            rigidBody.AddTorque(dirX, dirY, dirZ);
        }
    }
}
