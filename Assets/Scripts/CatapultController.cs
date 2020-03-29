using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            float force = 15f;
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), force, Input.GetAxis("Vertical"));
            other.GetComponent<Rigidbody>().AddForce(movement * 30);
        }
    }

}
