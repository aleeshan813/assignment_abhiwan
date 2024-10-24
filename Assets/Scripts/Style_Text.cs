using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Style_Text : MonoBehaviour
{
    public TMP_InputField inputField;

    bool isBold = false;
    bool isItalic = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    //Bold button function
    public void Bold()
    {
        isBold = !isBold;
        applyTextStyle();
    }

    //Italic button function
    public void Italic()
    {
        isItalic = !isItalic;
        applyTextStyle();
    }
    void applyTextStyle()
    {
        string currentText = inputField.text;

        //Rich Text tags
        currentText = currentText.Replace("<b>", "").Replace("</b>", "");
        currentText = currentText.Replace("<i>", "").Replace("</i>", "");

        if (isBold && isItalic)
            inputField.text = "<b><i>" + currentText + "</i></b>";
        else if (isBold)
            inputField.text = "<b>" + currentText + "</b>";
        else if (isItalic)
            inputField.text = "<i>" + currentText + "</i>";
        else
            inputField.text = currentText;
    }
}
