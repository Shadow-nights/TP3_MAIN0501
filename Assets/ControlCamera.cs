using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera rightFrontCamera;
    public Camera rightBackCamera;
    public Camera leftFrontCamera;
    public Camera leftBackCamera;

    private int currentCamera = 1;

    void Start()
    {
        // Initialisation de la caméra de départ
        mainCamera.enabled = true;
        rightFrontCamera.enabled = false;
        rightBackCamera.enabled = false;
        leftFrontCamera.enabled = false;
        leftBackCamera.enabled = false;
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
    }

    void SwitchCamera(int cameraNumber)
    {
        // Désactiver toutes les caméras
        mainCamera.enabled = false;
        rightFrontCamera.enabled = false;
        rightBackCamera.enabled = false;
        leftFrontCamera.enabled = false;
        leftBackCamera.enabled = false;

        // Activer la caméra sélectionnée
        switch (cameraNumber)
        {
            case 1:
                mainCamera.enabled = true;
                break;
            case 2:
                rightFrontCamera.enabled = true;
                break;
            case 3:
                rightBackCamera.enabled = true;
                break;
            case 4:
                leftFrontCamera.enabled = true;
                break;
            case 5:
                leftBackCamera.enabled = true;
                break;
        }

        // Mettre à jour la caméra actuelle
        currentCamera = cameraNumber;
    }
}
