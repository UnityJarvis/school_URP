using UnityEngine;
namespace Inucom.SchoolVR.UI
{
    public class CanvasSwitcher 
    {
        public static bool togglerer { get; set; }
        internal static void ScreenPosToggle()
        {
            togglerer = !togglerer;
        }
        internal static void ScreenTransition(Vector3 boardInitPos,Vector3 bigBoardScale,Vector3 smallBoardScale, Transform leftHandModelPos, Transform worldCanvasHolderPos, Transform CanvasUI, bool screenBoolValue)
        {
            if (screenBoolValue)
            {
                CanvasUI.transform.SetParent(worldCanvasHolderPos.transform);
                CanvasUI.transform.position = Vector3.MoveTowards(CanvasUI.transform.position, boardInitPos, 0.5f);
                CanvasUI.transform.rotation = Quaternion.Euler(0, 180, 0);
                CanvasUI.transform.localScale = bigBoardScale;
            }
            if (!screenBoolValue)
            {
                CanvasUI.transform.SetParent(leftHandModelPos.transform);
                CanvasUI.transform.position = Vector3.MoveTowards(CanvasUI.transform.position, leftHandModelPos.transform.position, 0.5f);
                CanvasUI.transform.rotation = leftHandModelPos.transform.rotation;
                CanvasUI.transform.localScale = smallBoardScale;
            }
        }
    }
}
