
using UnityEngine;

public class Lizer : MonoBehaviour
{
    public Transform start_point;
    public Transform end_point;
    public LineRenderer line_renderer;

    void Start()
    {
        line_renderer.positionCount = 2;
    }

    void Update()
    {
        if (start_point && end_point)
        {
            line_renderer.SetPosition(0, start_point.position);
            line_renderer.SetPosition(1, end_point.position);
        }
    }
}
