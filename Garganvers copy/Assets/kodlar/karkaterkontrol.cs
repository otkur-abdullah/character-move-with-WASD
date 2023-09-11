using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karkaterkontrol : MonoBehaviour
{
    public Transform Cam;
    public Rigidbody rb;
    public float speed;
    public float jumpSpeed;
    public float minJump;
    float x, z;
    Vector3 move = Vector3.zero;


    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        move = new Vector3(x, 0, z) * Time.deltaTime * speed;
        if (x != 0 || z != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Cam.transform.rotation, 0.3f);
        }
        rb.MovePosition(transform.position + transform.TransformDirection(move));   
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector3.up * Time.deltaTime * jumpSpeed;
        }
        if (x != 0 || z != 0)
        {
            rb.AddForce(Vector3.up * Time.deltaTime * minJump, ForceMode.VelocityChange);
        }
            
    }

}
