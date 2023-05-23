using UnityEngine;

namespace lesson3
{
    public class TorchLineRenderer : MonoBehaviour
    {
        LineRenderer lineRenderer;
        public Transform p1, p2;
        private void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, p1.position);
            lineRenderer.SetPosition(1, p2.position);
        }
        private void Update()
        {
            Debug.DrawRay(p1.transform.position, p1.transform.forward, Color.red);
        }
    }
}

