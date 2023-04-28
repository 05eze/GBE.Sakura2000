using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;


    private Queue<string> sentences;
    

    void Start()
    {
        sentences = new Queue<string>();
    }


    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Start of conversation with " + dialogue.name);
        
        //Name of NPC shown on dialogue box
        nameText.text = dialogue.name;


        //Clear any sentences that were shown before
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();


    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //Show text on dialogue box
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
}
