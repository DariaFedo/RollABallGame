using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class southWallMovement : MonoBehaviour
{
    private Vector3 position0 = new Vector3(0.0f, 0.0f, -9.6f);
    private Vector3 position1 = new Vector3(0.0f, 0.0f, -5.0f);
    public float speed;

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
        transform.position = Vector3.MoveTowards(transform.position, currentDestination, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentDestination) <= 0.5f)
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
