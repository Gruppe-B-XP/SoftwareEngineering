using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class RadialSection
{
    public Sprite icon = null;
    public SpriteRenderer iconRenderer = null;
    public UnityEvent onPress = new UnityEvent();
}
