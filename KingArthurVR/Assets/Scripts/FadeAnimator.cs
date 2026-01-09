using UnityEngine;

public class FadeAnimator : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim.SetTrigger("fadeIn");
    }

    void Update()
    {

    }
}