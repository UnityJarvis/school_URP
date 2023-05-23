using UnityEngine;

namespace lesson3
{
    public class LightMeterExp : MonoBehaviour
    {
        TorchLineRenderer _tLR;
        TMPro.TextMeshPro textMeshPro;
        private void Start()
        {
            _tLR = GetComponentInChildren<TorchLineRenderer>();
            textMeshPro = GetComponentInChildren<TMPro.TextMeshPro>();
        }
        private void FixedUpdate()
        {
            LuxMeter();
        }
        void LuxMeter()
        {
            RaycastHit hit;
            if (Physics.Raycast(_tLR.p1.position,_tLR.p1.transform.forward,out hit,10,11))
            {
                print("Found " + hit.collider.name + " at " + hit.distance);
                textMeshPro.text = (hit.distance * 100).ToString("0.0") + " LUX";
            }
        }
    }
}
