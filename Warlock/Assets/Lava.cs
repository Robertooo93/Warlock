using UnityEngine;

public class Lava : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Player on lava!");
    }
}
