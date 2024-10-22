using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grappin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        ArticulationBody articulationBody = collision.gameObject.GetComponent<ArticulationBody>();
        if (articulationBody != null){
            ConfigurableJoint joint = gameObject.AddComponent<ConfigurableJoint>();
            joint.connectedArticulationBody = articulationBody;
            joint.xMotion = ConfigurableJointMotion.Locked;
            joint.yMotion = ConfigurableJointMotion.Locked;
            joint.zMotion = ConfigurableJointMotion.Locked;
        } 
    }

    void Update(){
        if (Input.GetKey(KeyCode.Space)){
            ConfigurableJoint joint = GetComponent<ConfigurableJoint>();
            if (joint != null){
                Destroy(joint);
            }
        }
    }
}
