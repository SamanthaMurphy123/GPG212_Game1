using UnityEngine;

public class PlayAudioOnLocation : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform targetLocation;
    public float distanceThreshold = 1.0f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, targetLocation.position);

        if (distance <= distanceThreshold)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}