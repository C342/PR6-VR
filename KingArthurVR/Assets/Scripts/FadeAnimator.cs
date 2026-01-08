using UnityEngine;

public class FadeAnimator : MonoBehaviour
{
    public Animator anim;
    public Canvas canvas;

    private void Start()
    {
        anim.SetTrigger("fadeIn");
        canvas.enabled = true;
    }

    void Update()
    {

    }
}