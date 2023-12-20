using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    Rigidbody rb;
    Vector3 movement;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
    }


    void FixedUpdate()
    {
        moveCharacter(movement);
    }


    void moveCharacter(Vector3 direction)
    {
        //rb.MovePosition(rb.position + transform.TransformDirection(direction) * speed * Time.deltaTime);
        transform.position += direction * Time.deltaTime * speed;
    }

}
