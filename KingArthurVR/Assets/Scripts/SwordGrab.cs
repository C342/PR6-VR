using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(XRGrabInteractable))]
[RequireComponent(typeof(ConfigurableJoint))]
public class SwordGrab : MonoBehaviour
{
    private XRGrabInteractable grab;
    private ConfigurableJoint joint;

    void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();
        joint = GetComponent<ConfigurableJoint>();

        grab.selectEntered.AddListener(OnGrab);
        grab.selectExited.AddListener(OnRelease);

        LockJoint();
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        UnlockJoint();
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        LockJoint();
    }

    private void UnlockJoint()
    {
        joint.xMotion = ConfigurableJointMotion.Locked;
        joint.yMotion = ConfigurableJointMotion.Limited;
        joint.zMotion = ConfigurableJointMotion.Locked;
    }

    private void LockJoint()
    {
        joint.xMotion = ConfigurableJointMotion.Locked;
        joint.yMotion = ConfigurableJointMotion.Locked;
        joint.zMotion = ConfigurableJointMotion.Locked;
    }
}