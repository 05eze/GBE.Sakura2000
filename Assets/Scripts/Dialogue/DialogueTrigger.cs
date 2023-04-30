using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
   // public KeyCode keyToPress;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Press E to interact");
        
            if(other.gameObject.tag == "Player") 
            {
                TriggerDialogue();
            }
        
    }
}
