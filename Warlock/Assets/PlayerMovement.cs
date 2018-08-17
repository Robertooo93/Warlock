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
        transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(transform.forward,new Vector3(inputs.x,0,inputs.z),speed,0.0f));
        rb.MovePosition(rb.position + new Vector3(inputs.x,0,inputs.z) * speed * Time.fixedDeltaTime);
	}
}
