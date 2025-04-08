using UnityEngine;

public class SpaceDrumScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip soundEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Detect if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play the sound effect
            audioSource.PlayOneShot(soundEffect);
        }

    }
}
