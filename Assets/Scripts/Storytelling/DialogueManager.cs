using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    private Queue<string> lines;

    // Start is called before the first frame update
    void Start()
    {
        lines = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversion");

        lines.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            lines.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(lines.Count == 0) 
        {
            EndDialogue();
            return;
        }

        string sentence = lines.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }

}