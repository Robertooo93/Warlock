using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        Debug.Log("camera");
        if (player != null)
        {
            transform.position = player.position + offset;
        }
        else {
            transform.position = new Vector3(0, 20, -16);
            transform.rotation = Quaternion.Euler(60, 0, 0);
        }
	}
}
