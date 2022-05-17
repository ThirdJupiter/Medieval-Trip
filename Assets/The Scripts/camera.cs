using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // wasd p;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
  
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
