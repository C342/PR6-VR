using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(XRGrabInteractable))]
public class SwordGrab : MonoBehaviour
{
    private XRGrabInteractable grab;

    private Vector3 lockedWorldPos;
    public float maxPullUp = 0.15f;

    private bool isGrabbed;

    void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();

        grab.selectEntered.AddListener(OnGrab);
        grab.selectExited.AddListener(OnRelease);

        lockedWorldPos = transform.position;
    }

    void LateUpdate()
    {
        if (!isGrabbed)
            return;

        Vector3 pos = transform.position;

        pos.x = lockedWorldPos.x;
        pos.z = lockedWorldPos.z;

        pos.y = Mathf.Clamp(
            pos.y,
            lockedWorldPos.y,
            lockedWorldPos.y + maxPullUp
        );

        transform.position = pos;
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        isGrabbed = true;
        lockedWorldPos = transform.position;

        grab.trackRotation = false;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false;

        transform.position = lockedWorldPos;
    }
}