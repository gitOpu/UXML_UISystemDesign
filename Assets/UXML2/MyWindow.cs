 
using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MyWindow : EditorWindow
{
  // public   VisualTreeAsset visualTreeAsset;
   [MenuItem("Window/MyWindow")]
   public static void ShowWindow()
   {
       MyWindow w = GetWindow<MyWindow>();
      w.titleContent = new GUIContent("My Window");
     

   }

   private void CreateGUI()
   {
       /*VisualTreeAsset visualTreeAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(
           "Assets/UXML2/create-a-drag-and-drop-window-inside-a-custom-editor-window/DragAndDropWindow.uxml");
       var x = visualTreeAsset.Instantiate();
       rootVisualElement.Add(x);
       
       DragAndDropManipulator manipulator =
           new(rootVisualElement.Q<VisualElement>("object"));*/
   }
}
