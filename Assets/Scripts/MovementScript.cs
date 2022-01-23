using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    public float speed;
    Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float hMovement = Input.GetAxis("Horizontal");
        float vMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hMovement, 0, vMovement);
        playerRb.AddForce(movement * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            GameManager.coins -= 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Hazard"))
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
