using UnityEngine;

/// <summary>
/// Resolves head/geometry overlaps reported by <see cref="HeadCollisionDetector"/> by pushing
/// the rig's CharacterController out along the penetration vector, split into substeps so it
/// doesn't tunnel through corners. Runs off the camera's actual position each frame, independent
/// of locomotion input, so it also works when movement comes from the XR Device Simulator.
/// </summary>
public class HeadCollisionHandler : MonoBehaviour
{
    [SerializeField] HeadCollisionDetector _detector;
    [SerializeField] CharacterController _characterController;
    [SerializeField] bool _ignoreVertical = true;

    [SerializeField, Tooltip("Maximum distance, in meters, a single CharacterController.Move substep may cover.")]
    float _maxSubStepDistance = 0.05f;

    void FixedUpdate()
    {
        if (_detector == null || _characterController == null || !_detector.isColliding)
            return;

        var push = _detector.penetrationVector;
        if (_ignoreVertical)
            push.y = 0f;

        if (push.sqrMagnitude < 1e-10f)
            return;

        int stepCount = Mathf.Max(1, Mathf.CeilToInt(push.magnitude / _maxSubStepDistance));
        Vector3 subMove = push / stepCount;

        for (int i = 0; i < stepCount; i++)
            _characterController.Move(subMove);
    }
}
