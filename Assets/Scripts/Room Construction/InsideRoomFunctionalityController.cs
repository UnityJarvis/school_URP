using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InsideRoomFunctionalityController : MonoBehaviour
{
    public Material roomMirrorMaterial;
    public Slider intensitySlider;
    public void Deport(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void lightIntensity()
    {
        roomMirrorMaterial.color = new Color(roomMirrorMaterial.color.r, roomMirrorMaterial.color.g, roomMirrorMaterial.color.b, intensitySlider.value);
    }
}

