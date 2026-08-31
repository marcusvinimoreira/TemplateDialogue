using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public TMP_Text speechText;
    public TMP_Text actorNameText;


    [Header("Settings")]
    public float typingSpeed;
    private string[] sentences;
    private int index;

    public void Speech(Sprite p, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        sentences = txt;
        actorNameText.text = actorName;
        index = 0;
        speechText.text = "";
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        speechText.text = "";

        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        if (speechText.text == sentences[index])
        {
            //ainda há textos
            if (index < sentences.Length - 1)
            {
                index++;
                StartCoroutine(TypeSentence());

            }
            else //lido quando acaba os textos
            {

                
                CloseDialogue();
            }
        }
    }

    public void CloseDialogue()
    {
        StopCoroutine(TypeSentence());
        speechText.text = "";
        index = 0;
        dialogueObj.SetActive(false);
    }
}
