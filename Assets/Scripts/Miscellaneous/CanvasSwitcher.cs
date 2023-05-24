using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    public Vector3 boardPos, handPos;

    [Space]
    public Vector3 bigSize;
    public Vector3 smallSize;

    public Slider ss;

    public GameObject leftHand, deleteMe;

    public bool big, small;
    public void BigScreen()
    {
        big = !big;
        //small = false;
    }
    public void SmallScreen()
    {
        //big = false;
        //small = true;
    }

    private void Update()
    {
        if (big)//|| ss.value < 0.5)
        {
            transform.SetParent(deleteMe.transform);
            transform.position = Vector3.MoveTowards(transform.position, boardPos, 0.5f);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.localScale = bigSize;
        }
        if (!big)// || ss.value > 0.5)
        {
            transform.SetParent(leftHand.transform);
            transform.position = Vector3.MoveTowards(transform.position, leftHand.transform.position, 0.5f);
            transform.rotation = leftHand.transform.rotation;
            transform.localScale = smallSize;
        }
    }
}