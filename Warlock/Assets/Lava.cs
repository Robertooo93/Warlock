using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {
    
    private List<GameObject> players = new List<GameObject>();
    private float dmg_start_time = float.NaN;

    private void FixedUpdate()
    {
        if(float.IsNaN(dmg_start_time)) {
            dmg_start_time = Time.time;
        }
        bool dmgDone = false;
        foreach(GameObject player in players) {
            //Debug.Log("Time:" + (Time.time - test.dmg_start_time));
            if (Time.time - dmg_start_time > 0.1f)
            {
                if (player == null)
                    break;
                Health health = player.GetComponent<Health>();
                health.DealDamage(1);
                dmgDone = true;
            }
            else {
                break;
            }
        }
        if(dmgDone) {
            dmg_start_time = float.NaN;
        }
        players.Clear();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name.Equals("Player")) {
            Debug.Log("Player Entered to Lava");
            players.Add(other.gameObject);
        }
    }
}
