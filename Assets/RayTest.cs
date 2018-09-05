using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {

    public float rayLength = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray testRay1 = new Ray(transform.position, transform.up);
        Vector3 _direc1 = transform.forward + new Vector3(.25f,0,0);
        Vector3 _direc2 = transform.forward + new Vector3(.5f, 0, 0);
        Vector3 _direc3 = transform.forward + new Vector3(.75f, 0, 0);
        Vector3 _direc4 = transform.forward + new Vector3(0, 0, 0);
        Vector3 _direc5 = transform.forward + new Vector3(-.25f, 0, 0);
        Vector3 _direc6 = transform.forward + new Vector3(-.5f, 0, 0);
        Vector3 _direc7 = transform.forward + new Vector3(-.75f, 0, 0);

        Vector3 _direc8 = transform.forward + new Vector3(.25f, .25f, 0);
        Vector3 _direc9 = transform.forward + new Vector3(.5f, .25f, 0);
        Vector3 _direc10 = transform.forward + new Vector3(.75f, .25f, 0);
        Vector3 _direc12 = transform.forward + new Vector3(-.25f, .25f, 0);
        Vector3 _direc13 = transform.forward + new Vector3(-.5f, .25f, 0);
        Vector3 _direc14 = transform.forward + new Vector3(-.75f, .25f, 0);

        Vector3 _direc15 = transform.forward + new Vector3(.25f, -.25f, 0);
        Vector3 _direc16 = transform.forward + new Vector3(.5f, -.25f, 0);
        Vector3 _direc17 = transform.forward + new Vector3(.75f, -.25f, 0);
        Vector3 _direc18 = transform.forward + new Vector3(-.25f, -.25f, 0);
        Vector3 _direc19 = transform.forward + new Vector3(-.5f, -.25f, 0);
        Vector3 _direc20 = transform.forward + new Vector3(-.75f, -.25f, 0);


        Debug.DrawRay(transform.position, _direc1 * rayLength);
        Debug.DrawRay(transform.position, _direc2 * rayLength);
        Debug.DrawRay(transform.position, _direc3 * rayLength);
        Debug.DrawRay(transform.position, _direc4 * rayLength);
        Debug.DrawRay(transform.position, _direc5 * rayLength);
        Debug.DrawRay(transform.position, _direc6 * rayLength);
        Debug.DrawRay(transform.position, _direc7 * rayLength);
        Debug.DrawRay(transform.position, _direc8 * rayLength);
        Debug.DrawRay(transform.position, _direc9 * rayLength);
        Debug.DrawRay(transform.position, _direc10 * rayLength);
        Debug.DrawRay(transform.position, _direc12 * rayLength);
        Debug.DrawRay(transform.position, _direc13 * rayLength);
        Debug.DrawRay(transform.position, _direc14 * rayLength);
        Debug.DrawRay(transform.position, _direc15 * rayLength);
        Debug.DrawRay(transform.position, _direc16 * rayLength);
        Debug.DrawRay(transform.position, _direc17 * rayLength);
        Debug.DrawRay(transform.position, _direc18 * rayLength);
        Debug.DrawRay(transform.position, _direc19 * rayLength);
        Debug.DrawRay(transform.position, _direc20 * rayLength);

        if (Physics.Raycast(testRay1, out hit, rayLength))
        {
            Debug.Log(hit.collider.name);
        }
	}
}
