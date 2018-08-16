using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5f;
    public float rotateSpeed = 3f;

    private Rigidbody rb;
    private Vector3 inputs = Vector3.zero;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        inputs = Vector3.zero;
        inputs.x = CrossPlatformInputManager.GetAxis("Horizontal");
        inputs.z = CrossPlatformInputManager.GetAxis("Vertical");
        Debug.Log(inputs);
        transform.Rotate(0, inputs.x, 0);
        if(inputs.z > 0) {
            Debug.Log("Move forward");
        }
        else if(inputs.z < 0) {
            Debug.Log("Move backward");
        }
        rb.MovePosition(rb.position + inputs * speed * Time.fixedDeltaTime);
	}
}
