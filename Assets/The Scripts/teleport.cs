using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour
{

    public int iLevelToLoad;
  
    public bool useIntToLoadLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if (collisionGameObject.tag == "Player")
        {
            LoadScene();
        }
    }


    void LoadScene()
    {
        if (useIntToLoadLevel)
        {
            SceneManager.LoadScene(iLevelToLoad);
        }
       
    }
}
