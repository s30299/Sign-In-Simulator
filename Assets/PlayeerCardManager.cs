using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayeerCardManager : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text ageText;
    public TMP_InputField descriptionInputField;

    public void UpdateName(string newName)
    {
        nameText.text = newName;
    }

    public void UpdateDescription(string newDescription)
    {
        descriptionText.text = newDescription;
    }
    public void SubmitDescription(string newDescription) {
    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
        descriptionInputField.ActivateInputField();
        descriptionInputField.caretPosition = descriptionInputField.text.Length;
        return;
    }
    descriptionText.text = newDescription;
}

    public void UpdateAge(float newValue)
    {
        ageText.text = newValue.ToString() + " years old";
    }
}
