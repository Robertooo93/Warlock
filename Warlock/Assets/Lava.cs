using UnityEngine;

public class Lava : MonoBehaviour {

    private float dmg_start_time = float.NaN;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name.Equals("Player")) {
            Debug.Log("Player on lava!");
            Debug.Log("Time:"+ (Time.time - dmg_start_time));
            if (float.IsNaN(dmg_start_time) || Time.time - dmg_start_time > 0.1f)
            {
                Health health = other.gameObject.GetComponent<Health>();
                health.DealDamage(1);
                dmg_start_time = Time.time;
            }
        }
    }
}
