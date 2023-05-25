using UnityEngine;

namespace InuCom.SchoolVR.Audio
{
    public class UiSounds
    {
        internal static void BreakSound(AudioSource audioSource, AudioClip audioClip)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
