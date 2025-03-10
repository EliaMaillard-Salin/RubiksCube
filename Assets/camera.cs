using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float mouseDeltaX = Input.GetAxis("Mouse X");

            //Vector3 target = transform.rotation.eulerAngles;
            //target.y += mouseDeltaX * 1000.0f * Time.deltaTime;

            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, target, Time.deltaTime / 5);

            transform.Rotate(-Vector3.up, mouseDeltaX * 1000.0f * Time.deltaTime,Space.World);
            
            float mouseDeltaY= Input.GetAxis("Mouse Y");

            transform.Rotate(-Vector3.left, mouseDeltaY * 1000.0f * Time.deltaTime, Space.World);
        }
    }   
}
