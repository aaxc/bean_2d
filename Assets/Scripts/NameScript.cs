using TMPro;
using UnityEngine;

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
    }
}
