using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFireBall : MonoBehaviour {

    private Vector3 startPos;
	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Start: "+ startPos);
        Debug.Log("Current: " + transform.position);
        Debug.Log("Distance: " + Vector3.Distance(startPos, transform.position));
        if(Vector3.Distance(startPos,transform.position)>10f) {
            Destroy(this.gameObject);
        }
	}
}
