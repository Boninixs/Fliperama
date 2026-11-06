using UnityEngine;

/// <summary>
/// Detects when the head (camera) intersects level geometry, e.g. when physically walking
/// through a wall during room-scale tracking. Checks the camera's actual world position every
/// frame, so it works regardless of what moved it (locomotion input, teleport, the XR Device
/// Simulator, or real head tracking). Exposes the push-out vector needed to resolve the overlap;
/// <see cref="HeadCollisionHandler"/> consumes it to move the rig.
/// </summary>
public class HeadCollisionDetector : MonoBehaviour
{
    [SerializeField] float _radius = 0.15f;
    [SerializeField] LayerMask _collisionMask = ~0;
    [SerializeField] int _maxOverlaps = 8;

    Collider[] _overlapBuffer;
    SphereCollider _probe;

    public Vector3 penetrationVector { get; private set; }
    public bool isColliding => penetrationVector.sqrMagnitude > 0f;

    void Awake()
    {
        _overlapBuffer = new Collider[_maxOverlaps];

        var probeObj = new GameObject("[Head Collision Probe]");
        probeObj.transform.SetParent(transform, false);
        probeObj.layer = gameObject.layer;
        _probe = probeObj.AddComponent<SphereCollider>();
        _probe.isTrigger = true;
        _probe.radius = _radius;
    }

    void FixedUpdate()
    {
        penetrationVector = Vector3.zero;

        var probePosition = _probe.transform.position;
        var probeRotation = _probe.transform.rotation;

        int count = Physics.OverlapSphereNonAlloc(probePosition, _radius, _overlapBuffer, _collisionMask, QueryTriggerInteraction.Ignore);

        for (int i = 0; i < count; i++)
        {
            var other = _overlapBuffer[i];
            if (other == null || other == _probe || other.transform.IsChildOf(transform))
                continue;

            if (Physics.ComputePenetration(
                    _probe, probePosition, probeRotation,
                    other, other.transform.position, other.transform.rotation,
                    out var direction, out var distance))
            {
                penetrationVector += direction * distance;
            }
        }
    }
}
