using UnityEngine;

public class CanvasSwitcher : MonoBehaviour
{
    public Vector3 boardPos, handPos;

    [Space]
    public Vector3 bigSize;
    public Vector3 smallSize;

    public GameObject leftHand, deleteMe;

    public bool big;
    public void BigScreen()
    {
        big = !big;
    }
    private void Update()
    {
        if (big)
        {
            transform.SetParent(deleteMe.transform);
            transform.position = Vector3.MoveTowards(transform.position, boardPos, 0.5f);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.localScale = bigSize;
        }
        if (!big)
        {
            transform.SetParent(leftHand.transform);
            transform.position = Vector3.MoveTowards(transform.position, leftHand.transform.position, 0.5f);
            transform.rotation = leftHand.transform.rotation;
            transform.localScale = smallSize;
        }
    }
}