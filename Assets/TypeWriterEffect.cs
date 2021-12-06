using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{
    Text textTarget;
    string fullText;
    public float typeSpeed = 0.1f;

    public static TypeWriterEffect typeWriterEffect;

    private void Awake()
    {
        textTarget = GetComponent<Text>();
        fullText = textTarget.text;
        textTarget.text = "";
    }

    public void TypeEffectStart()
    {
        StartCoroutine("PlayText");
    }

    IEnumerator PlayText()
    {
        foreach (char character in fullText)
        {
            textTarget.text += character;
            yield return new WaitForSeconds(typeSpeed);
        }
    }


}
