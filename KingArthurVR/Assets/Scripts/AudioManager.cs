using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }

    public void StopPlaying()
    {
        audioSource.Stop();
    }
}