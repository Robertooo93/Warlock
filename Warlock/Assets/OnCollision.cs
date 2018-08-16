using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

    void OnCollisionEnter (Collision collision) {
        Debug.Log("Collision with: "+collision.gameObject.name);
        if(collision.gameObject.name.Equals("Player")) {
            Debug.Log("push");
            Health health = collision.gameObject.GetComponent<Health>();
            health.DealDamage(10);
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 10,ForceMode.VelocityChange);
            Destroy(this.gameObject);
        }
	}
	
}
