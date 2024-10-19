using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;

    private int currentCamera = 1;

    void Start()
    {
        // Initialisation de la caméra de départ
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;
        currentCamera = 1;
    }

    void Update()
    {
        // Vérifier les touches de 1 à 5 pour changer de caméra
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchCamera(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SwitchCamera(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SwitchCamera(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SwitchCamera(6);
        }
    }

    void SwitchCamera(int cameraNumber)
    {
        // Désactiver toutes les caméras
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;
        cam4.enabled = false;
        cam5.enabled = false;
        cam6.enabled = false;

        // Activer la caméra sélectionnée
        switch (cameraNumber)
        {
            case 1:
                cam1.enabled = true;
                break;
            case 2:
                cam2.enabled = true;
                break;
            case 3:
                cam3.enabled = true;
                break;
            case 4:
                cam4.enabled = true;
                break;
            case 5:
                cam5.enabled = true;
                break;
            case 6:
                cam6.enabled = true;
                break;
        }

        // Mettre à jour la caméra actuelle
        currentCamera = cameraNumber;
    }
    void OnGUI(){
        Rect rect = new Rect(10, 10, 200, 300);
        // GUIDE UTILISATION GRUE
        GUI.Box(rect, "Contrôles de la grue");
        GUI.Label(new Rect(20, 40, 180, 20), "Pour bouger : les flèche (<^>)");
        GUI.Label(new Rect(20, 60, 180, 20), "Deployer les bras : (E) et (D)");
        GUI.Label(new Rect(20, 80, 180, 20), "Encrée la grue : (R) et (F)");
        GUI.Label(new Rect(20, 100, 180, 20), "Déployer/Replier le chariot avec (Z) et (S)");
        GUI.Label(new Rect(20, 120, 180, 20), "Bouger la Flèche : (A) et (Q)");
        GUI.Label(new Rect(20, 140, 180, 20), "Tourner la Flèche : (Y) et (H)");
        GUI.Label(new Rect(20, 160, 180, 20), "Lacher un objet: (espace)");
        GUI.Label(new Rect(20, 180, 180, 20), "Vue globale : 1");
        GUI.Label(new Rect(20, 200, 180, 20), "Vue de face : 2");
        GUI.Label(new Rect(20, 220, 180, 20), "Retro intérieur : 3");
        GUI.Label(new Rect(20, 240, 180, 20), "Retro G : 4");
        GUI.Label(new Rect(20, 260, 180, 20), "Retro D : 5");
        GUI.Label(new Rect(20, 280, 180, 20), "Vue crochet : 6");

    }
}
