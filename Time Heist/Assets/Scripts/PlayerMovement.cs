using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float speed = 0.02f; // tunable parameter

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            this.transform.position += this.transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.S)) {
            this.transform.position += -this.transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.D)) {
            this.transform.position += this.transform.right * speed;
        }

        if (Input.GetKey(KeyCode.A)) {
            this.transform.position += -this.transform.right * speed;
        }
    }
}
