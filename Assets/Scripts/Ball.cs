using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 direction;
    public int Range;
    private int iteration = 0;
    private int updateCount = 100;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (++iteration == updateCount)
        {
            iteration = 0;
            rb.AddForce(new Vector3(Random.Range(-Range, Range), 0, Random.Range(-Range, Range)));
        }
    }
}
