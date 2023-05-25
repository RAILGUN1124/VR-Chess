using UnityEngine;

public class ChessSoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlaySound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
