using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[Serializable]
public class Card
{
    public Texture2D image;
    public int health;
    public int attack;

}
public class UIManager : MonoBehaviour
{
    public List<Card> Cards;
    public void Start()
    {
        UIDocument document = GetComponent<UIDocument>();

        // Load the UXML document that defines the hierarchy of CardElement.
        // It assumes the UXML file is placed at the "Resources" folder.
        VisualTreeAsset template = Resources.Load<VisualTreeAsset>("CardElement");

        // Create a loop to modify properties and perform interactions 
        // for each card.  It assumes that you have created a function 
        // called `GetCards()` to get all the cards in your game.
        foreach(Card card in Cards)
        {
            // Instantiate a template container.
            var templateContainer = template.Instantiate();

            // Find the custom element inside the template container.
            var cardElement = templateContainer.Q<CardElement>();

            // Add the custom element into the scene.
            document.rootVisualElement.Add(cardElement);

            // Initialize the card.
            cardElement.Init(card.image, card.health, card.attack);

            // Register an event callback for additional interaction.
            cardElement.RegisterCallback<ClickEvent>(SomeInteraction);
        }
    }

    private void SomeInteraction(ClickEvent evt)
    {
      Debug.Log($"SomeInteraction {evt.button.ToString()}");
    }
}