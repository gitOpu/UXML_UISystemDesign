using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// Define the custom control type.
public class CardElement : VisualElement
{
    private string status;

    // Expose the custom control to UXML and UI Builder.
  public new class UxmlFactory : UxmlFactory<CardElement, UxmlTraits> {}
    public new class UxmlTraits : VisualElement.UxmlTraits
    {
        UxmlStringAttributeDescription m_Status = new UxmlStringAttributeDescription { name = "status" };
//Define attributes on elements

        public override IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
        {
            get { yield break; }
        }

        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
        {
            base.Init(ve, bag, cc);
            ((CardElement)ve).status = m_Status.GetValueFromBag(bag, cc);
        }
    }
    private VisualElement portraitImage => this.Q("image");
    private Label attackBadge => this.Q<Label>("attack-badge");
    private Label healthBadge => this.Q<Label>("health-badge");

    // Use the Init() approach instead of a constructor because 
    // we don't have children yet.
    public void Init(Texture2D image, int health, int attack)
    {
        portraitImage.style.backgroundImage = image;
        attackBadge.text = $"{attack}";
        healthBadge.text = $"{health}";
    }

    // Custom controls need a default constructor. 
    public CardElement() {}
}