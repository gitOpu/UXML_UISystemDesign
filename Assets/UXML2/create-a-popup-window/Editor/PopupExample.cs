using UnityEditor;
using UnityEngine.UIElements;
using PopupWindow = UnityEditor.PopupWindow;


namespace UIToolkitExamples_15{
public class PopupExample : EditorWindow
{
    // Add menu item
    [MenuItem("Window/UIToolkitExamples/Popup Example 15")]
    static void Init()
    {
        EditorWindow window = EditorWindow.CreateInstance<PopupExample>();
        window.Show();
    }

    private void CreateGUI()
    {
        var visualTreeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/UXML2/create-a-popup-window/Editor/PopupExample.uxml");
        visualTreeAsset.CloneTree(rootVisualElement);

        var button = rootVisualElement.Q<Button>();
        button.clicked += () => PopupWindow.Show(button.worldBound, new PopupContentExample());
    }
}
}