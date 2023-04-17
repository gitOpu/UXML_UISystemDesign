using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    
    void Start()
    {
        LoadCart();
    }
    [SerializeField] private int numberOfCart = 4;
    private void LoadCart()
    {
        UIDocument document = GetComponent<UIDocument>();
        var grid = document.rootVisualElement.Q<VisualElement>("Grid");
        VisualTreeAsset template = Resources.Load<VisualTreeAsset>("Cart");
        for (int i = 0; i < 4; i++)
        {
            var cardElement = template.Instantiate();
            grid.Add(cardElement);
        }
    }
}
