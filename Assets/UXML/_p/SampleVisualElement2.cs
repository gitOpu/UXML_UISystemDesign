using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SampleVisualElement2 : VisualElement
{
    private string status;
    public new class UxmlFactory : UxmlFactory<SampleVisualElement2, UxmlTraits> {}
    
    public new class UxmlTraits : VisualElement.UxmlTraits
    {
        UxmlStringAttributeDescription m_Status = new UxmlStringAttributeDescription { name = "status" };

        public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
        {
            get { yield break; }
        }

        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
        {
            base.Init(ve, bag, cc);
            ((SampleVisualElement2)ve).status = m_Status.GetValueFromBag(bag, cc);
        }
    }
    
}
