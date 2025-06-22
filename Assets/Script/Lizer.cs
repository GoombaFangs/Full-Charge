using UnityEngine;

public class Lizer : MonoBehaviour
{
    [Header("Laser Settings")]
    public Transform startPoint;
    public Transform endPoint;
    public LineRenderer lineRenderer;

    void Start()
    {
        if (lineRenderer == null)
            lineRenderer = GetComponent<LineRenderer>();

        DrawLaser();
    }

    void DrawLaser()
    {
        if (startPoint == null || endPoint == null) return;

        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, startPoint.position);
        lineRenderer.SetPosition(1, endPoint.position);
    }

    void Update()
    {
        DrawLaser(); // ???? ????? ??? ?? ???? ????? ?? ????? ?????
    }
}