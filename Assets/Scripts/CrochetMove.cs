using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrochetMove : MonoBehaviour
{
    public float torque = 250f;
    public float forceChariot = 500f;
    public float forceMoufle = 500f;
    public ArticulationBody chariot;
    public ArticulationBody mouffle;
    
    void Start(){
        
    }
    void Update(){
        //Commande Chariot
        if(Input.GetKey(KeyCode.UpArrow)){
            chariot.AddRelativeForce(transform.right * forceChariot);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            chariot.AddRelativeForce(transform.right * -forceChariot);
        }

        //Commande Moufle
        if(Input.GetKey(KeyCode.LeftShift)){
            mouffle.AddRelativeForce(transform.up * forceChariot);
        }
        if(Input.GetKey(KeyCode.LeftControl)){
            mouffle.AddRelativeForce(transform.up * -forceChariot);
        }
    }
}

