using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnableBoard : MonoBehaviour
{
    public GameObject Enable1;
    public GameObject Enable2;
    public GameObject Enable3;
    public GameObject Enable4;

    public TextMeshProUGUI Disable1;
    public TextMeshProUGUI Disable2;
    public TextMeshProUGUI Disable3;

    public void OnButtonClick()
    {
        Enable1.gameObject.SetActive(true);
        Enable2.gameObject.SetActive(true);
        Enable3.gameObject.SetActive(true);
        Enable4.gameObject.SetActive(true);

        Disable1.gameObject.SetActive(false);
        Disable2.gameObject.SetActive(false);
        Disable3.gameObject.SetActive(false);
    }
}