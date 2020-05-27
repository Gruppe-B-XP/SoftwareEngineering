using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InputManager : MonoBehaviour
{
    [Header("Actions Left")]
    public SteamVR_Action_Boolean touchLeft = null;
    public SteamVR_Action_Boolean pressLeft = null;
    public SteamVR_Action_Vector2 touchPositionLeft = null;

    [Header("Actions Right")]
    public SteamVR_Action_Boolean touchRight = null;
    public SteamVR_Action_Boolean pressRight = null;
    public SteamVR_Action_Vector2 touchPositionRight = null;

    [Header("Scene Objects")]
    public RadialMenu radialMenuLeft = null;
    public RadialMenu radialMenuRight = null;

    private void Awake()
    {
        touchLeft.onChange += TouchLeft;
        pressLeft.onStateUp += PressReleaseLeft;
        touchPositionLeft.onAxis += PositionLeft;

        touchRight.onChange += TouchRight;
        pressRight.onStateUp += PressReleaseRight;
        touchPositionRight.onAxis += PositionRight;
    }
    private void OnDestroy()
    {
        touchLeft.onChange -= TouchLeft;
        pressLeft.onStateUp -= PressReleaseLeft;
        touchPositionLeft.onAxis -= PositionLeft;

        touchRight.onChange -= TouchRight;
        pressRight.onStateUp -= PressReleaseRight;
        touchPositionRight.onAxis -= PositionRight;
    }
    private void PositionRight(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta)
    {
        radialMenuRight.SetTouchPosition(axis);
    }

    private void TouchRight(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState)
    {
        radialMenuRight.Show(newState);
    }
    private void PressReleaseRight(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        radialMenuRight.ActivateHighlightedSection();
    }
    private void PositionLeft(SteamVR_Action_Vector2 fromAction, SteamVR_Input_Sources fromSource, Vector2 axis, Vector2 delta)
    {
        radialMenuLeft.SetTouchPosition(axis);
    }

    private void TouchLeft(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource, bool newState)
    {
        radialMenuLeft.Show(newState);
    }
    private void PressReleaseLeft(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        radialMenuLeft.ActivateHighlightedSection();
    }
}
