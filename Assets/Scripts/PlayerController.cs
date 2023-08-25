using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    float xInput;
    float yInput;

    public GameObject winText;
    public GameObject timeText;
 
    Rigidbody rb;

    int coninsCollected;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");


        if (transform.position.y <= -5f)
        {
            SceneManager.LoadScene(0);
        }

    }

    private void FixedUpdate()
    {
        rb.AddForce(xInput * moveSpeed, 1, yInput * moveSpeed);
      
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Coin")
        {
            coninsCollected++;
            other.gameObject.SetActive(false);
        }
       if (coninsCollected >= 27)
        {
            winText.SetActive(true);
        }

    }
}
