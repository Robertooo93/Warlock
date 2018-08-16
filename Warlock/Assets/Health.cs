using UnityEngine;

public class Health : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth = 100;

    public Transform healthBar;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DealDamage(int dmg) {
        currentHealth -= dmg;

        healthBar.localScale = new Vector3(healthBar.localScale.x, healthBar.localScale.y, currentHealth / 100f);

        if(currentHealth <= 0) {
            Die();
        }
    }

    private void Die() {
        Debug.Log("Died");
        Destroy(this.gameObject);
    }
}
