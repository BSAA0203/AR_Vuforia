using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float rotate_speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            float rotx= Input.GetAxis("Mouse X")*rotate_speed*Mathf.Deg2Rad;
            float roty= Input.GetAxis("Mouse Y")*rotate_speed*Mathf.Deg2Rad;

            this.transform.RotateAround(Vector3.up,-rotx);
            this.transform.RotateAround(Vector3.right,roty);
        }
    }
}
