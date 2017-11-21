using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class HeadsetManager : MonoBehaviour {
    public GameObject viveRig;
    public GameObject oculusRig;
    private bool hmdChosen;

	// Use this for initialization
	void Start () {
        if(VRDevice.model == "vive")
        {
            viveRig.SetActive(true);
            oculusRig.SetActive(false);
            hmdChosen = true;
        }
        else if(VRDevice.model == "oculus")
        {
            oculusRig.SetActive(true);
            viveRig.SetActive(false);
            hmdChosen = true;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!hmdChosen)
        {
            if (VRDevice.model == "vive")
            {
                viveRig.SetActive(true);
                oculusRig.SetActive(false);
                hmdChosen = true;
            }
            else if (VRDevice.model == "oculus")
            {
                oculusRig.SetActive(true);
                viveRig.SetActive(false);
                hmdChosen = true;
            }
        }
        if (!VRDevice.isPresent)
        {
            hmdChosen = false;
            //Do code to sync up the CameraRigs states 
            //such as position here
        }
		
	}
}
