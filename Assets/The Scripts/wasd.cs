using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float speed = 10f;
    // public PointEffector2D p;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DontDestroyOnLoad(gameObject);
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
       

    }
    
}
