using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SampleVisualElement : VisualElement
{
    public new class UxmlFactory : UxmlFactory<SampleVisualElement, UxmlTraits> {}
}