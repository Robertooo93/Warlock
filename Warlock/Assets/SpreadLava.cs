using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpreadLava : MonoBehaviour {

    public float x = 0f;
    public float y = 0f;
    public float z = 0f;

    public int maxInvokeNumber = 0;

    private int invokeNumber = 0;

	// Use this for initializa stion
	void Start () {
        InvokeRepeating("Spread", 10.0f, 10.0f);
	}
	
    void Spread() {
        if (invokeNumber++ < maxInvokeNumber)
        {
            Debug.Log("Spread");
            transform.localScale = transform.localScale + new Vector3(x, y, z);
        }
        else {
            Debug.Log("Spread cancelled");
            CancelInvoke("Spread");
        }
    }
}
