using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour {

    GameObject mainCamO;
    Transform mainCamT;

	// Use this for initialization
	void Start () {
        mainCamO = GameObject.Find("Main Camera");
        mainCamT = mainCamO.transform;

    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(2 * transform.position - mainCamT.position);
	}
}
