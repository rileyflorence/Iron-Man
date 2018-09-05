using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactPoint : MonoBehaviour {

    public Transform explosionPrefab;
    public Vector3 hitSpot;
    public Quaternion hitAngle;

    void OnCollisionStay(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        hitSpot = pos;
        hitAngle = rot;
        //Instantiate(explosionPrefab, pos, rot);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
