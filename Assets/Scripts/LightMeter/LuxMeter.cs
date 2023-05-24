using UnityEngine;

namespace InuCom.SchoolVR.physics
{
    namespace LightAndMatter.lesson_3
    {
        public class LuxMeter : MonoBehaviour
        {
            internal static void LuxMeterReading(Transform rayOrigin, TMPro.TextMeshPro luxMeterReading3DText)
            {
                RaycastHit hit;
                if (Physics.Raycast(rayOrigin.position, rayOrigin.transform.forward,out hit,10,11))
                {
                    print("Found " + hit.collider.name + " at " + hit.distance);
                    luxMeterReading3DText.text = (hit.distance * 100).ToString("0.0") + " LUX";
                }

                Debug.DrawRay(rayOrigin.transform.position, rayOrigin.transform.forward, Color.red);
            }
        }
    }
}
