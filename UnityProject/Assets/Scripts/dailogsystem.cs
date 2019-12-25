using UnityEngine;
using UnityEngine.UI;

public class dailogsystem : MonoBehaviour
{

    [Header("介面")]
    public Text textName;
    public Text textContent;
    public CanvasGroup uiGroup;

    public void ShowDialog(string gerName,string getContent)
    {
        uiGroup.alpha = 1;
        textName.text = gerName;
        textContent.text = getContent;
    }
}
