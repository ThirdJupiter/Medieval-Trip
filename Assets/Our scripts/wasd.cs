using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10.5f;
    //public player = p;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //player = GetComponent<PlayerPrefs>(); 

    }

    // Update is called once per frame
    void Update()
    {
          Vector3 pos = transform.position;
       
        if (Input.GetKey(KeyCode.W)) pos.y += speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.A)) pos.x -= speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S)) pos.y -= speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D)) pos.x += speed * Time.deltaTime;

        transform.position = pos;
       
    }
    
}
