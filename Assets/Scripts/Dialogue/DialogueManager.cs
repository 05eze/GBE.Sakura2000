using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using RigidbodyConstraints2D;

public class DialogueManager : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    public Text nameText;

    public Text dialogueText;

    public Animator animator;
    //public Button continueButton;

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
        Cursor.lockState = CursorLockMode.Locked;   

       /* if(Scene.name == "Classroom")
        {
            Cursor.lockState = CursorLockMode.None;
        }*/
    }


    public void StartDialogue (Dialogue dialogue)
    {
       // rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        Cursor.lockState = CursorLockMode.None;
        Debug.Log("Start of conversation with " + dialogue.name);

        animator.SetBool("isOpen", true);

        //Name of NPC shown on dialogue box
        nameText.text = dialogue.name;

        //Time.timeScale = 0f;

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
        //dialogueText.text = sentence;
    }


    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }


    void EndDialogue()
    {
        Cursor.lockState = CursorLockMode.Locked;
        animator.SetBool("isOpen", false);
        Debug.Log("End of conversation");

       // Time.timeScale = 1f;

      //  rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }


    void Update()
    {
        //Press the space bar to apply no locking to the Cursor
        if (Input.GetKey(KeyCode.Alpha1))
            Cursor.lockState = CursorLockMode.None;
    }


    void OnGUI()
    {
        //Press this button to lock the Cursor
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
