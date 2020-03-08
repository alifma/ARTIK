using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Torch : MonoBehaviour
{

    private bool onOff = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleFlash()
    {
        if (onOff == false)
        {
            CameraDevice.Instance.SetFlashTorchMode(true);
            onOff = true;
        }
        else
        {
            CameraDevice.Instance.SetFlashTorchMode(false);
            onOff = false;
        }
    }
}
