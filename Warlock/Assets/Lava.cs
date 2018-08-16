using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {
    
    List<Test> targets = new List<Test>();

    private void Update()
    {
        foreach(Test test in targets) {
            Debug.Log("Time:" + (Time.time - test.dmg_start_time));
            if (float.IsNaN(test.dmg_start_time) || Time.time - test.dmg_start_time > 0.1f)
            {
                Health health = test.player.GetComponent<Health>();
                health.DealDamage(1);
                test.dmg_start_time = Time.time;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name.Equals("Player") && !Exists(other.gameObject)) {
            Debug.Log("Player Entered to Lava");
            targets.Add(new Test(other.gameObject,float.NaN));

        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit1");
        if (other.gameObject.name.Equals("Player") && Exists(other.gameObject))
        {
            Debug.Log("Exit2");
            foreach (Test test in targets)
            {
                if (test.player.Equals(other.gameObject))
                {
                    Debug.Log("Player Exited from Lava");
                    targets.Remove(test);
                }
            }
        }
    }

    private bool Exists(GameObject player)
    {
        foreach (Test test in targets) {
            if(test.player.Equals(player)) {
                return true;
            }
        }
        return false;
    }

    private class Test {
        public GameObject player { get; set; }
        public float dmg_start_time { get; set; }

        public Test(GameObject player, float dmg_start_time) {
            this.player = player;
            this.dmg_start_time = dmg_start_time;
        }
    }

}
