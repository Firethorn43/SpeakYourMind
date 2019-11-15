using UnityEngine;
using System.Collections;

public class BootUpText : MonoBehaviour
{
    public GameObject bootUpText;
    bool showText;

    void Start()
    {
        showText = false;
        bootUpText.SetActive(showText);
    }

    public void OnClick()
    {
        showText = !showText;
        bootUpText.SetActive(showText);
    }
}