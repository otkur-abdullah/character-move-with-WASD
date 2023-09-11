using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camer_control : MonoBehaviour
{
    public Transform target;
    public float mousSpeed;
    float xrot, yrot;
    public float minX, maxX;
    

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        xrot -= Input.GetAxis("Mouse Y") * Time.deltaTime * mousSpeed;
        yrot += Input.GetAxis("Mouse X") * Time.deltaTime * mousSpeed;
        xrot = Mathf.Clamp(xrot, minX, maxX);
        transform.GetChild(0).localRotation = Quaternion.Euler(xrot, 0, 0);
        transform.localRotation = Quaternion.Euler(0, yrot, 0);
        transform.position = Vector3.Lerp(transform.position+new Vector3(0, 0.1f, 0), target.transform.position, 0.3f);
    }


   

    
}
