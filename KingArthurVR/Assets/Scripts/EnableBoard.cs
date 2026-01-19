using System.Runtime.CompilerServices;
using UnityEngine;

public class EnableBoard : MonoBehaviour
{
    public Transform Storyboard;

    void Start()
    {

    }

    void Update()
    {
        GameObject.Find("Storyboard").SetActive(false);
    }
}
