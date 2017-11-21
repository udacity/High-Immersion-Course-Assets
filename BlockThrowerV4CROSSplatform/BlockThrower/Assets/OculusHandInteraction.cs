using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusHandInteraction : MonoBehaviour {
    public SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device device;
    public float throwForce = 1.5f;

    private OVRInput.Controller thisController;
    public bool leftHand; //if true this is the left hand controller
    //Swipe
    public float swipeSum;
    public float touchLast;
    public float touchCurrent;
    public float distance;
    public bool hasSwipedLeft;
    public bool hasSwipedRight;
    public ObjectMenuManager objectMenuManager;
    private bool menuIsSwipable;
    private float menuStickX;

	// Use this for initialization
	void Start () {
        

        if (leftHand)
        {
            thisController = OVRInput.Controller.LTouch;
        }
        else
        {
            thisController = OVRInput.Controller.RTouch;
        }
	}
	
	// Update is called once per frame
	void Update () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        if (leftHand)
        {
            menuStickX = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick,
                thisController).x;
            if(menuStickX < 0.45f && menuStickX > -0.45f)
            {
                menuIsSwipable = true;
            }
            if (menuIsSwipable)
            {
                if(menuStickX >= 0.45f)
                {
                    //fire function that looks at menuList,
                    //disables current item, and enables next item
                    objectMenuManager.MenuRight();
                    menuIsSwipable = false;
                }
                else if(menuStickX <= -0.45f)
                {
                    objectMenuManager.MenuLeft();
                    menuIsSwipable = false;
                }
            }
        }
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, thisController))
        {
            objectMenuManager.SpawnCurrentObject();
        }
      }


    void SpawnObject()
    {
        objectMenuManager.SpawnCurrentObject();
    }

    void SwipeLeft()
    {
        objectMenuManager.MenuLeft();
        Debug.Log("SwipeLeft");
    }
    void SwipeRight()
    {
        objectMenuManager.MenuRight();
        Debug.Log("SwipeRight");
    }
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, 
                thisController) < 0.1f)
            {
                ThrowObject(col);    
            }
            else if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger,
                thisController) > 0.1f)
            {
                GrabObject(col);
            }
        }
    }
    void GrabObject(Collider coli)
    {
        coli.transform.SetParent(gameObject.transform);
        coli.GetComponent<Rigidbody>().isKinematic = true;
        device.TriggerHapticPulse(2000);
        Debug.Log("You are touching down the trigger on an object");
    }
    void ThrowObject(Collider coli)
    {
        coli.transform.SetParent(null);
        Rigidbody rigidBody = coli.GetComponent<Rigidbody>();
        rigidBody.isKinematic = false;
        rigidBody.velocity =
            OVRInput.GetLocalControllerVelocity(thisController) * throwForce;
        rigidBody.angularVelocity =
            OVRInput.GetLocalControllerAngularVelocity(thisController).eulerAngles;
        Debug.Log("You have released the trigger");
    }
}
