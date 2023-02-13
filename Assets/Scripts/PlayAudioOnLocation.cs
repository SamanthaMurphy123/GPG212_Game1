using UnityEngine;

public class PlayAudioOnLocation : MonoBehaviour
{
    public AudioClip clip;
    public float volume = 1.0f;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(clip, volume);
    }
}