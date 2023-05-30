using UnityEngine;
using InuCom.SchoolVR.physics.LightAndMatter.lesson_2;
using InuCom.SchoolVR.physics.LightAndMatter.lesson_3;
using InuCom.SchoolVR.physics.LightAndMatter.lesson_4;
using BNG;

public class GameManager : MonoBehaviour
{
    [Header("Exp 3 LightMeter")]
    [Space(10)]
    public LineRenderer lineRenderer;
    public Transform p1, p2;
    public TMPro.TextMeshPro luxReading, Detector3DText;

    [Header("Exp 4 MirrorConstruction")]
    [Space(10)]
    public GameObject paint;
    public SnapZone snapPoint;
    public Grabbable glassGrabbale;
    public GameObject MirrorCamRenderer;
    public Grabbable silverGrabbable;

    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        TorchLineRenderer.torchRenderer(lineRenderer, p1, p2);
    }
    private void Update()
    {
        MirrorConstructionValidator.MirrorValidation(snapPoint, glassGrabbale, MirrorCamRenderer);
    }
    private void FixedUpdate()
    {
        //LuxMeter.LuxMeterReading(p1, luxReading);
        Detector3DText.text = LuxMeter.LuxMeterReading(p1, luxReading).text;
    }

    public void TeleportPlayer(int sceneIndex)
    {
        PlayerTeleporter.RoomSceneLoader(sceneIndex);
    }
}

