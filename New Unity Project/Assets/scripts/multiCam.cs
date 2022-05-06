using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiCam : MonoBehaviour
{
    public Camera Normalcam;
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
        Normalcam.enabled = false;
    }

    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView()
    {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
        Normalcam.enabled = false;
    }
    public void NormalCam()
    {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = false;
        Normalcam.enabled = true;
    }
}
