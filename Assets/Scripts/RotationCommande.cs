using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCommande : MonoBehaviour
{
    public GameObject Rotation;
    public string axe;
    public int Sens = 1;

    //Commande pour l'articulation de rotation
    //Pour tourner la flèche positif : W - négatif : X
    //Pour tourner  les supports positif : E - négatif : A
    //Pour déployer les supports au sol positif : F - négatif : R
    //Pour touner le mat positif : V - négatif : C
    //la liste des commandes est dans l'input manager

    void Update()//envoie l'état de mouvement à RotationControleur
    {
        float input = Input.GetAxis(axe);
        EtatRotation rotationState = MoveStateForInput(input);
        RotationControleur controller = Rotation.GetComponent<RotationControleur>();
        controller.rotationState = rotationState;
    }

    //envoie dans quel état de mouvement l'articulation devrait être
    EtatRotation MoveStateForInput(float input)
    {
        if (Sens == 1)
        {
            if (input > 0)
            {
                return EtatRotation.Positif;
            }
            else if (input < 0)
            {
                return EtatRotation.Negatif;
            }
            else
            {
                return EtatRotation.Fixe;
            }
        }
        else if (Sens == -1)
        {
            if (input < 0)
            {
                return EtatRotation.Positif;
            }
            else if (input > 0)
            {
                return EtatRotation.Negatif;
            }
            else
            {
                return EtatRotation.Fixe;
            }
        }
        else
        {
            return EtatRotation.Fixe;
        }
    }
}
