using System.Collections;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    private Vector3 previousPosition;
    private AudioSource audioSource;
    private bool isPlaying;
    private bool isFirstFrame;

    void Start()
    {
        previousPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
        isPlaying = false;
        isFirstFrame = true;
    }

    void Update()
    {
        // If this is the first frame of the game, just update the previousPosition and return
        if (isFirstFrame)
        {
            previousPosition = transform.position;
            isFirstFrame = false;
            return;
        }

        if (transform.position != previousPosition && !isPlaying)
        {
            StartCoroutine(PlaySound());
            previousPosition = transform.position;
        }
    }

    IEnumerator PlaySound()
    {
        isPlaying = true;
        audioSource.Play();
        yield return new WaitForSeconds(5f);
        audioSource.Stop();
        isPlaying = false;
    }
}