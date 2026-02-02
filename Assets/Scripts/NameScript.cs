using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    private string text;

    readonly private string[] sampleText = {
        "Hello",
        "Have a nice day",
        "Nice to see you",
        "Look what' s here",
        "Goodbye"
    };

    public GameObject inputField;

    public GameObject outputField;

    public GameObject reverseText;

    public void GetText()
    {
        int randomIx = Random.Range(0, sampleText.Length);

        text = inputField.GetComponent<TMP_InputField>().text;

        outputField.GetComponent<TMP_Text>().text = sampleText[randomIx] + " " + text.ToUpper() + "!";

        reverseText.GetComponent<Toggle>().interactable = true;
        if (reverseText.GetComponent<Toggle>().isOn) {
            ReverseText();
        }
    }

    public void ReverseText()
    {
        char[] charArray = outputField.GetComponent<TMP_Text>().text.ToCharArray();
        System.Array.Reverse(charArray);
        outputField.GetComponent<TMP_Text>().text = new string(charArray);
    }
}
