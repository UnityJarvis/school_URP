using UnityEngine;
using InuCom.SchoolVR.physics.LightAndMatter.lesson_3;
using Inucom.SchoolVR.UI;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("LightMeter")]
    [Space(10)]
    public LineRenderer lineRenderer;
    public Transform p1, p2;
    public TMPro.TextMeshPro luxReading,Detector3DText;

    [Header("Canvas Board")]
    [Space(10)]
    public Button boardButton;
    public Vector3 boardInitPos;
    public Vector3 bigBoardScale;
    public Vector3 smallBoardScale;
    public Transform leftHandPos, worldCanvasHolderPos,canvasUIParent;
    bool screenBoolPos ;

    private void Start()
    {
        boardButton.onClick.AddListener(CanvasSwitcher.ScreenPosToggle);
        TorchLineRenderer.torchRenderer(lineRenderer, p1, p2);
    }
    private void FixedUpdate()
    {
        //LuxMeter.LuxMeterReading(p1, luxReading);
        Detector3DText.text = LuxMeter.LuxMeterReading(p1, luxReading).text;
    }

    private void Update()
    {
        screenBoolPos = CanvasSwitcher.togglerer;
        CanvasSwitcher.ScreenTransition(boardInitPos,bigBoardScale,smallBoardScale,leftHandPos,worldCanvasHolderPos,canvasUIParent,screenBoolPos);
    }
}

