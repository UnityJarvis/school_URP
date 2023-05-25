using UnityEngine;
using InuCom.SchoolVR.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClipsHolder audioClipsHolder;
    public AudioSource audioSource;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            UiSounds.BreakSound(audioSource, audioClipsHolder.audioClips[0]);
        }
    }
}
