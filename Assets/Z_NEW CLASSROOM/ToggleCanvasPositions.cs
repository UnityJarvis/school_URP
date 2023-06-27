using UnityEngine;
public class ToggleCanvasPositions
{
    public static void Toggling(Transform gameObject, Vector3 finalPos, float scalee)
    {
        gameObject.position = finalPos;
        gameObject.localScale = new Vector3(scalee,scalee,scalee);
    }
}