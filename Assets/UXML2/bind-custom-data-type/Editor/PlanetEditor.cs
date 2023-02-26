using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

namespace UIToolkitExamples_02
{
    [CustomEditor(typeof(PlanetScript))]
    public class PlanetEditor : Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            return new PropertyField(serializedObject.FindProperty("coreTemperature"));
        }
    }
}