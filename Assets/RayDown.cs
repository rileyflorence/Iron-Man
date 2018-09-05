using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDown : MonoBehaviour {
    public Vector3 hitSpot;
    public Quaternion hitAngle;
    public Transform block;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

    RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);
        int layerMask = 1 << 9;

        Debug.DrawRay(transform.position, Vector3.down * 2, Color.red);

        if (Physics.Raycast(ray, out hit, 2, layerMask))
        {
            hitAngle = Quaternion.FromToRotation(Vector3.up, hit.normal);
            hitSpot = hit.point;
            block.transform.position = hitSpot + new Vector3 (0, .03f, 0);
            block.transform.rotation = hitAngle;
        }
        else
        {
            block.transform.position = Vector3.zero;
        }
        
    }


}
