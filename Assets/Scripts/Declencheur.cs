using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Declencheur : MonoBehaviour{
    public int nbCaisse =0;    
    public string Couleur;
    // Start is called before the first frame update
    void Start(){

    }
    
    // Update is called once per frame
    void Update(){

    }
    //Cette fonction sert à savoir si un objet est bien entrée dans la zone de dépôt
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Charge")){
            nbCaisse++;
            Debug.Log("Il y'a "+nbCaisse+" objets dans la zone "+Couleur);
        }
    }
    //Cette fonction sert à savoir si un objet est bien sortie de la zone de dépôt
    void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Charge")){
            if(nbCaisse>0){
                nbCaisse--;
            }
            Debug.Log("Il y'a "+nbCaisse+" objets dans la zone "+Couleur);
        }
    }
}

