using UnityEngine;
using UnityEngine.UI;
using InuCom.SchoolVR.Audio;

public class AudioManager : MonoBehaviour
{
    public Button boardSwitchButton;
    public AudioClipsHolder audioClipsHolder;
    public AudioSource audioSource;

    private void Start()
    {
        boardSwitchButton.onClick.AddListener(() => UiSounds.ClickSound(audioSource, audioClipsHolder.audioClips[0]));
    }
}
