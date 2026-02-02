using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource sFXSource;

    public AudioClip[] audioClips;

    public void PlaySFX(int ix)
    {
        if (sFXSource.isPlaying)
        {
            sFXSource.Stop();
        }

        sFXSource.PlayOneShot(audioClips[ix]);
    }
}
