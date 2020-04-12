using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    public Vector3 m_Offset = Vector3.zero;

    [HideInInspector]
    public Hand m_activeHand = null;

    public void ApplyOffset(Transform hand)
    {
        transform.SetParent(hand);
        transform.localRotation = Quaternion.identity;
        transform.localPosition = m_Offset;
        transform.SetParent(null);
    }
}