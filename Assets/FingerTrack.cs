using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerTrack : MonoBehaviour {

    public Transform finger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(finger.position.x, finger.position.y, .48f);		
	}
}
