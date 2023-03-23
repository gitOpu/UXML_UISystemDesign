namespace v1
{
    using UnityEngine;
    using UnityEngine.UIElements;

    public class UIButtonWithCustomData : Button
    {
        public new class UxmlFactory : UxmlFactory<UIButtonWithCustomData, UxmlTraits>
        {
        }

        public new class UxmlTraits : Button.UxmlTraits
        {
            UxmlStringAttributeDescription m_String = new UxmlStringAttributeDescription
                {name = "string-data", defaultValue = "default_value"};

            UxmlIntAttributeDescription m_Int = new UxmlIntAttributeDescription {name = "int-data", defaultValue = 1};

            UxmlStringAttributeDescription m_JSon = new UxmlStringAttributeDescription
                {name = "json-data", defaultValue = "{}"};

            public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
            {
                base.Init(ve, bag, cc);
                var ate = ve as UIButtonWithCustomData;

                ate.StringData = m_String.GetValueFromBag(bag, cc);
                ate.IntData = m_Int.GetValueFromBag(bag, cc);
                ate.JsonData = m_JSon.GetValueFromBag(bag, cc);
                /*
             private VisualElement portraitImage => this.Q("image");
   private Label attackBadge => this.Q<Label>("attack-badge");
   private Label healthBadge => this.Q<Label>("health-badge");
             */
            }
        }

        public string StringData { get; set; }
        public int IntData { get; set; }
        public string JsonData { get; set; }
        /*
          public void Init(Texture2D image, int health, int attack)
   {
       portraitImage.style.backgroundImage = image;
       attackBadge.text = $"{attack}";
       healthBadge.text = $"{health}";
   }

    
   public TabBarView() {}
          */
    }

}