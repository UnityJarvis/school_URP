using UnityEngine;
using UnityEngine.UI;
using Inucom.SchoolVR.UI;

public class UiManager : MonoBehaviour
{
    [Header("Canvas Board")]
    [Space(10)]
    public Button boardButton;
    public Vector3 boardInitPos;
    public Vector3 bigBoardScale;
    public Vector3 smallBoardScale;
    public Transform leftHandPos, worldCanvasHolderPos, canvasUIParent;
    bool screenBoolPos;

    private void Start()
    {
        CanvasSwitcher.togglerer = true;                //Set Position of board to wall
        boardButton.onClick.AddListener(CanvasSwitcher.ScreenPosToggle);
    }
    private void Update()
    {
        screenBoolPos = CanvasSwitcher.togglerer;
        CanvasSwitcher.ScreenTransition(boardInitPos, bigBoardScale, smallBoardScale, leftHandPos, worldCanvasHolderPos, canvasUIParent, screenBoolPos);
    }

}
