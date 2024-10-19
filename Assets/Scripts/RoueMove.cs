using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoueMove : MonoBehaviour
{
    Rigidbody rb;
    public bool isGrounded;
    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionStay(){
        isGrounded = true;
    }
    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.up * -0.0030f);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.up * 0.0030f);
            if(Input.GetKey(KeyCode.LeftShift)){
                transform.Translate(Vector3.up * 0.002f);
            }
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(Vector3.forward * -0.5f);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(Vector3.forward * 0.5f);
        }
    }
}
