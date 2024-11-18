using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] int posY;
    [SerializeField] int speed;
    [SerializeField] int maxspeed;
    [SerializeField] GameObject meta;
    [SerializeField] GameObject gameManager;

    Rigidbody rb; 
    Vector3 input;

    void Start()
    {

        rb = GetComponent<Rigidbody>(); 

        
    }

    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (transform.position.y < -6 || Input.GetKeyDown(KeyCode.R))
        {
            GameManager.RestartLevel();
        }

        
    }

    private void FixedUpdate()
    {
        if (rb.linearVelocity.magnitude < maxspeed)
        {
            rb.AddForce(input * speed * Time.fixedDeltaTime);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == meta)
        {
            GameManager.LoadNextLevel();
        }

        if (collision.gameObject.GetComponent<Enemy>() != null)
        {
            GameManager.RestartLevel();
        }

        


    }
}
