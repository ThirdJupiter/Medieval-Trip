using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{


    [SerializeField] Rigidbody2D rb;
    public float speed = 10f;
    // public PointEffector2D p;
    List<ConversationSkelly> convoBoys = new List<ConversationSkelly>();
    [SerializeField] Dialogue ui;

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
    

    private void TalkTo()
    {
        if (convoBoys.Count < 1) return;
        Child c;
        float closestDistance = float.MaxValue;
        int closestIndex = 0;
        for (int i = 0; i < convoBoys.Count; i++)
        {
            float d = Vector3.Distance(transform.position, convoBoys[i].transform.position);
            if (d < closestDistance)
            {
                closestDistance = d;
                closestIndex = i;
            }
        }

        ui.ShowMessage(convoBoys[closestIndex].GetResponse(), 1.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ConversationSkelly sk;
        if (collision.TryGetComponent<ConversationSkelly>(out sk))
        {
            convoBoys.Add(sk);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ConversationSkelly sk;
        if (collision.TryGetComponent<ConversationSkelly>(out sk))
        {
            convoBoys.Remove(sk);
        }
    }
}
