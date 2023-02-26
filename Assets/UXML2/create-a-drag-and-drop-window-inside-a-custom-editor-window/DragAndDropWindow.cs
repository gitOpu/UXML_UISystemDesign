using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


namespace UIToolkitExamples_14
{
    public class DragAndDropWindow : EditorWindow
    {
        [MenuItem("Window/UIToolkitExamples/Drag And Drop 14 ")]
        public static void ShowExample()
        {
            DragAndDropWindow wnd = GetWindow<DragAndDropWindow>();
            wnd.titleContent = new GUIContent("Drag And Drop 14 ");
        }

        public void CreateGUI()
        {
            // Each editor window contains a root VisualElement object
            VisualElement root = rootVisualElement;

            // Import UXML
            VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
                "Assets/UXML2/create-a-drag-and-drop-window-inside-a-custom-editor-window/DragAndDropWindow.uxml");
            var labelFromUXML = visualTree.Instantiate();
            root.Add(labelFromUXML);

            // A stylesheet can be added to a VisualElement.
            // The style will be applied to the VisualElement and all of its children.
            // var styleSheet  = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/UXML2/create-a-drag-and-drop-window-inside-a-custom-editor-window/DragAndDropWindow.uss");

            DragAndDropManipulator manipulator =
                new(rootVisualElement.Q<VisualElement>("object"));


        }

    }
}