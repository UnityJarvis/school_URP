using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.Video;
using InuCom.SchoolVR.UI.Videos;
using Inucom.SchoolVR.UI;

public class UIMan : MonoBehaviour
{
    [Header("Board Panels")]
    public List<GameObject> allPanels;
    public List<Button> startPanelButtons;
    public List<Button> experimentPanelButtons;


    [Space(10)]
    [Header("VideoPanel")]
    public RectTransform viewport;
    public List<ContentSizeFitter> videoPlayerContextPanel;
    public VideoPlayer videoPlayerComponent;
    public VideoLessons[] VideoLessonsArray;

    [Space(5)]
    [Header("Board Position Toggle")]
    public Button toggleBtn;
    public Vector3 boardInitPos;
    public Vector3 bigBoardScale;
    public Vector3 smallBoardScale;
    public Transform leftHandPos, worldCanvasHolderPos, canvasUIParent;
    bool screenBoolPos;

    //----------------------------------------------------------------------------

    private void Start()
    {
        allPanels[0].GetComponentsInChildren(startPanelButtons);
        foreach (Button btn in startPanelButtons) { btn.onClick.AddListener(() => StartPanelButtonFunction(btn.name)); }
        allPanels[1].GetComponentsInChildren(experimentPanelButtons);
        foreach (Button btn in experimentPanelButtons) { btn.onClick.AddListener(() => ExperimentPanelButtonFunction(int.Parse(btn.name))); }

        viewport.GetComponentsInChildren(videoPlayerContextPanel);

        for (int i = 0; i < videoPlayerContextPanel.Count; i++) { VideoPanelButtonsInstantiator.InstantiateButton(VideoLessonsArray[i], videoPlayerContextPanel[i].transform, videoPlayerComponent); }

        //---------Disable All panels and Enable only Start Panel--------------------
        foreach (GameObject panel in allPanels) { panel.SetActive(false); }
        allPanels[0].SetActive(true);

        CanvasSwitcher.togglerer = true;                //Set Position of board to wall
        toggleBtn.onClick.AddListener(CanvasSwitcher.ScreenPosToggle);
        //---------------------------------------------------------------------------
    }
    private void Update()
    {
        screenBoolPos = CanvasSwitcher.togglerer;
        CanvasSwitcher.ScreenTransition(boardInitPos, bigBoardScale, smallBoardScale, leftHandPos, worldCanvasHolderPos, canvasUIParent, screenBoolPos);
    }
    void StartPanelButtonFunction(string buttonName)
    {
        if (buttonName == "Start")
        {
            foreach (GameObject panel in allPanels) { panel.SetActive(false); }
            allPanels[1].SetActive(true);
        }
    }
    void ExperimentPanelButtonFunction(int contextIndex)
    {
        foreach (GameObject panel in allPanels) { panel.SetActive(false); }
        allPanels[2].SetActive(true);
        foreach (ContentSizeFitter ctx in videoPlayerContextPanel) { ctx.gameObject.SetActive(false); }
        videoPlayerContextPanel[contextIndex - 1].gameObject.SetActive(true);
    }
}
