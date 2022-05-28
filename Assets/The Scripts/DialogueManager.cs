using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{

    Queue<string> Sentences;

    //// Start is called before the first frame update
    void Start()
    {
        Sentences = new Queue<string>();
    }

    //public void StartDialogue(Dialogue dialogue);
   
    //{ 
       // Debug.Log("Starting Dialogue with " + dialogue.child); 
    //}

    
 
}
