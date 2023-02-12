using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
