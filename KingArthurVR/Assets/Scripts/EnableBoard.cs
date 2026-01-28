using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnableBoard : MonoBehaviour
{
    public GameObject Enable1;
    public GameObject Enable2;
    public GameObject Enable3;
    public GameObject Enable4;                              
    public GameObject Enable5;

    public GameObject Disable1;
    public GameObject Disable2;
    public GameObject Disable3;
    public GameObject Disable4;
    public GameObject Disable5;

    public GameObject Destroy1;

    public void OnButtonClick()
    {
        Enable1.gameObject.SetActive(true);
        Enable2.gameObject.SetActive(true);
        Enable3.gameObject.SetActive(true);
        Enable4.gameObject.SetActive(true);
        Enable5.gameObject.SetActive(true);

        Disable1.gameObject.SetActive(false);
        Disable2.gameObject.SetActive(false);
        Disable3.gameObject.SetActive(false);
        Disable4.gameObject.SetActive(false);
        Disable5.gameObject.SetActive(false);
    }
}