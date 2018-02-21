using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {

    public float moveSpeed;
    public float moveRange;

    private GameObject gobj;
    private Vector3 oldPosition;
	// Use this for initialization
	void Start () {
        gobj = gameObject;
        oldPosition = gobj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        gobj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
        if (Vector3.Distance(oldPosition, gobj.transform.position) > moveRange) {
            gobj.transform.position = oldPosition;
        }
    }
}
