using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    

    public Text nameText;
    public Text dialogText;
    private Queue<string> sentences;


    string fullText;

    // Start is called before the first frame update
    void Start()
    {
        fullText = dialogText.text;
        
        sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Conversation Start");
        nameText.text = dialogue.name;


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
        dialogText.text = sentence;
    }

    void EndDialogue()
    {
        Debug.Log("Ending");
    }



}
