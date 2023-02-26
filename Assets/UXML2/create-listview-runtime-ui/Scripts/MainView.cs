using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkitExamples_18
{
    public class MainView : MonoBehaviour
    {
        [SerializeField] VisualTreeAsset m_ListEntryTemplate;

        void OnEnable()
        {
            // The UXML is already instantiated by the UIDocument component
            var uiDocument = GetComponent<UIDocument>();

            // Initialize the character list controller
            var characterListController = new CharacterListController();
            characterListController.InitializeCharacterList(uiDocument.rootVisualElement, m_ListEntryTemplate);
        }
    }
}