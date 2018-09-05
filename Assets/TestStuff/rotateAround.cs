using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAround : MonoBehaviour {

    public Transform centerObj;
    public int rx;
    public int ry;
    public int rz;
    public int speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(centerObj.position, new Vector3(rx,ry,rz) , speed * Time.deltaTime);

    }
}
