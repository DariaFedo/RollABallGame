using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    private Vector3 position0 = new Vector3(-17.0f, 0.0f, -7.9f);
    private Vector3 position1 = new Vector3(-17.0f, 3.0f, -7.9f);
    private float speed;
    PlayerController playerSpeed = new PlayerController();

    

    Vector3 currentDestination;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = position0;
        currentDestination = position1;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = PlayerController.elevatorSpeed;
        MoveElevator(speed);
        //transform.position = Vector3.MoveTowards(transform.position, currentDestination, speed * Time.deltaTime);

        //if (Vector3.Distance(transform.position, currentDestination) <= 0.1f)
        //{
        //    if (currentDestination == position0)
        //    {
        //        currentDestination = position1;
        //    }
        //    else
        //    {
        //        currentDestination = position0;
        //    }
        //}
    }

    void MoveElevator(float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, currentDestination, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentDestination) <= 0.1f)
        {
            if (currentDestination == position0)
            {
                currentDestination = position1;
            }
            else
            {
                currentDestination = position0;
            }
        }
    }
}
