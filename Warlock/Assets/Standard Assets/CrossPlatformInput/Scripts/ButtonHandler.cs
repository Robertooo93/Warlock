using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {

        public string Name;
        public GameObject prefab;
        public Transform player;
        public Vector3 offset;

        void OnEnable()
        {
            
        }

        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaa");
            GameObject fireBall = Instantiate(prefab) as GameObject;
            fireBall.transform.position = player.transform.position + offset;
            Rigidbody rb = fireBall.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, 10);

        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive(Name);
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero(Name);
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative(Name);
        }

        public void Update()
        {

        }
    }
}
