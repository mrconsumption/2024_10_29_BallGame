using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    [SerializeField] int strength;
    [SerializeField] ParticleSystem particles;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * strength, ForceMode.VelocityChange);

        Instantiate(particles, transform.position, Quaternion.identity);
    }

}
