using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InsideRoomFunctionalityController : MonoBehaviour
{
    public Material roomMirrorMaterial;
    public Slider propsSlider;
    public Light propsRoomLight;

    [Space(10)]
    public Slider playerSlider;
    public Light playerRoomLight;
    public Material torchFrontGlass;

    private void Awake()
    {
        roomMirrorMaterial.color = new Color(roomMirrorMaterial.color.r, roomMirrorMaterial.color.g, roomMirrorMaterial.color.b, 0f);
    }

    public void Deport(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void lightIntensity()
    {
        roomMirrorMaterial.color = new Color(roomMirrorMaterial.color.r, roomMirrorMaterial.color.g, roomMirrorMaterial.color.b, propsSlider.value);
        propsRoomLight.intensity = (1f - propsSlider.value) * 10;
    }
    public void playerLightIntensity()
    {
        playerRoomLight.intensity = playerSlider.value;
        torchFrontGlass.SetColor("_EmissionColor", new Color(playerSlider.value * 255, playerSlider.value * 255, playerSlider.value * 255));
    }
}

