using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
<<<<<<< Updated upstream
    public AudioSource source;

    private void Awake()
    {

=======
    public AudioSource sourceSFX;

    private void Awake()
    {
>>>>>>> Stashed changes
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
<<<<<<< Updated upstream

        DontDestroyOnLoad(this);

        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
       //source.Stop();
        source.loop = false;
        source.PlayOneShot(clip);
    }
=======
        DontDestroyOnLoad(this);
    }
    
    public void PlaySound(AudioClip clip)
    {
        sourceSFX.PlayOneShot(clip);
    }

>>>>>>> Stashed changes
}
