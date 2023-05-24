using UnityEngine;
using InuCom.SchoolVR.physics.LightAndMatter.lesson_3;


public class GameManager : MonoBehaviour
{
    [Header("LightMeter")]
    [Space(10)]
    public LineRenderer lineRenderer;
    public Transform p1, p2;
    public TMPro.TextMeshPro luxReading,Detector3DText;
    private void Start()
    {
        TorchLineRenderer.torchRenderer(lineRenderer, p1, p2);
    }
    private void FixedUpdate()
    {
        //LuxMeter.LuxMeterReading(p1, luxReading);
        Detector3DText.text = LuxMeter.LuxMeterReading(p1, luxReading).text;
    }
}

