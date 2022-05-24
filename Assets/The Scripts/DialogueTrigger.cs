using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;

    public void TriggerDialoge ()
    {
        FindObjectOfType<DialogManager>().StartDialogue(dialogue);
    }
}
