using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xAxis;
    private float yAxis;
    private Vector3 movement;
    private Rigidbody2D rb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello SGDA!");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");
        print("X: " + xAxis + " " + "Y: " + yAxis);
        movement = new Vector3(xAxis,yAxis,0);
    }

    void FixedUpdate() {
        rb.velocity = movement * moveSpeed;
    }
}
