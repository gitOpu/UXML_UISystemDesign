using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class Card
{
    public Texture2D image;
    public string name;
    public int health;
}
public class UIManager : MonoBehaviour
{
    public List<Card> Cards;
    public void Start()
    {
        UIDocument document = GetComponent<UIDocument>();
        VisualElement grid = document.rootVisualElement.Q<VisualElement>("Grid");
        VisualTreeAsset template = Resources.Load<VisualTreeAsset>("CardElement");
        foreach(Card card in Cards)
        {
            var templateContainer = template.Instantiate();
            var cardElement = templateContainer.Q<CardElement>();
            cardElement.Init(card.image, card.name, card.health);
            cardElement.Q<Button>("btn_unlock").RegisterCallback<ClickEvent>(SomeInteraction);
            grid.Add(templateContainer);
        }
    }
    private void SomeInteraction(ClickEvent evt)
    {
      Debug.Log($"SomeInteraction {evt.button.ToString()}");
    }
}