using System.Collections;
using UnityEngine;
using Valve.VR;

public class Teleporter : MonoBehaviour
{
    public GameObject m_Pointer;
    public SteamVR_Action_Boolean m_TeleportAction;

    private SteamVR_Behaviour_Pose m_Pose = null;
    private bool m_HasPosition = false;
    private bool m_IsTeleporting = false;
    private float m_FadeTime = 0.5f;

    private void Awake()
    {
        m_Pose = GetComponent<SteamVR_Behaviour_Pose>();
    }

    private void Update()
    {
        // Pointer
        m_HasPosition = UpdatePointer();
        m_Pointer.SetActive(m_HasPosition);

        // Teleport
        if (m_TeleportAction.GetStateUp(m_Pose.inputSource))
            TryTeleport();
    }

    private void TryTeleport()
    {
        // Check for valiid Position, and if already teleporting
        if (!m_HasPosition || m_IsTeleporting)
            return;

        // Get camera rig and head postition
        Transform camerRig = SteamVR_Render.Top().origin;
        Vector3 headPosition = SteamVR_Render.Top().head.position;

        // Figure out translation
        Vector3 groundPosition = new Vector3(headPosition.x, camerRig.position.y, headPosition.z);
        Vector3 translateVector = m_Pointer.transform.position - groundPosition;

        // Move
        StartCoroutine(MoveRig(camerRig, translateVector));
    }

    private IEnumerator MoveRig(Transform cameraRig, Vector3 translation)
    {
        // Flag
        m_IsTeleporting = true;

        // Fade to black
        SteamVR_Fade.Start(Color.black, m_FadeTime, true);
        yield return new WaitForSeconds(m_FadeTime);

        // Apply Translation
        cameraRig.position += translation;

        // Fade to clear
        SteamVR_Fade.Start(Color.clear, m_FadeTime, true);
        yield return new WaitForSeconds(m_FadeTime);

        // De-flag
        m_IsTeleporting = false;

        yield return null;
    }

    private bool UpdatePointer()
    {
        // Ray from Controller
        Ray ray = new Ray(transform.position, transform.forward-transform.up);
        RaycastHit hit;

        // If it's a hit on the floor
        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Floor"))
        {
            m_Pointer.transform.position = hit.point;
            return true;
        }

        // If it's not a hit
        return false;
    }
}
