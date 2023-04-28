using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;
    public Button continueButton;
    private Queue<string> sentences;

   
    

    void Start()
    {
        sentences = new Queue<string>();
    }


    public void StartDialogue (Dialogue dialogue)
    {
        animator.SetBool("isOpen", true);


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
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        //Show text on dialogue box
        dialogueText.text = sentence;
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
      //  continueButton.interactable = true;
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        Debug.Log("End of conversation");
    }
}
