using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
    // public PointEffector2D p;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //player = GetComponent<PlayerPrefs>(); 
       //p = GetComponent<PointEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = Vector2.zero;
       
        if (Input.GetKey(KeyCode.W)) vel.y += speed;

        if (Input.GetKey(KeyCode.A)) vel.x -= speed;

        if (Input.GetKey(KeyCode.S)) vel.y -= speed;

        if (Input.GetKey(KeyCode.D)) vel.x += speed;

        rb.velocity = vel;
       
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    string 
        //}

    }
    
}
