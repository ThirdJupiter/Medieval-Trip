using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textCompnent;
    public string[] lines;
    public float textSpeed;

    private int index;

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    
    void Start()
    {
        textCompnent.text = string.Empty;
        StartDialogue(); //when to trigger?
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (textCompnent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textCompnent.text = lines[index];
            }
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textCompnent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textCompnent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
