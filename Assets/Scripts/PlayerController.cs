using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text counter;
    public Text winMessage;

    private Rigidbody rb;
    private int points;

    public GameObject gameElement;
    public GameObject[] elements;
    public GameObject catapult;

    public static float elevatorSpeed;

    public static float Name
    {
        get { return elevatorSpeed; }
        set { elevatorSpeed = value; }

    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        points = 0;
        SetCountText();
        winMessage.text = " ";
        catapult = GameObject.FindWithTag("Stairs");
        catapult.SetActive(false);
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        rb.AddForce(movement * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            points++;
            SetCountText();
        }

    }

    private void SetCountText()
    {
        counter.text = "Points: " + points.ToString();
        if (points == 12)
        {
            catapult.SetActive(true);
        }
        else if (points >= 24)
        {
            winMessage.text = "You win!";
            HideGameElements();
            elevatorSpeed = 1;
        }
            
    }

    private void HideGameElements()
    {
        
        elements = GameObject.FindGameObjectsWithTag("GameElement");
        
        foreach (GameObject gameElement in elements)
        {
            gameElement.SetActive(false);
        }
    }
}
