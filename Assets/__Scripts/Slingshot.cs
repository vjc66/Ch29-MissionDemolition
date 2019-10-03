using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// YOU must implement the Slingshot

public class Slingshot : MonoBehaviour {
    public GameObject launchPoint;

    void Awake() {
        Transform launchPointTrans = transform.Find("LaunchPoint");            // a
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);                                         // b
    }

    void OnMouseEnter() {
        //print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);                                           // b
    }

    void OnMouseExit() {
        //print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);                                          // b
    }

}
