using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnableBoard : MonoBehaviour
{
    public GameObject Storyboard1;
    public GameObject Storyboard2;
    public GameObject Storyboard3;

    public TextMeshProUGUI ButtonText;
    public TextMeshProUGUI TitleText;

    public void OnButtonClick()
    {
        Storyboard1.SetActive(true);
        Storyboard2.SetActive(true);
        Storyboard3.SetActive(true);

        ButtonText.gameObject.SetActive(false);
        TitleText.gameObject.SetActive(false);
    }
}