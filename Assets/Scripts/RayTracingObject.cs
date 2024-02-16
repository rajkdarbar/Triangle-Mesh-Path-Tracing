using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class RayTracingObject : MonoBehaviour
{
    private void OnEnable()
    {
        PathTracingMaster.RegisterObject(this);
    }

    private void OnDisable()
    {
        PathTracingMaster.UnregisterObject(this);
    }
}