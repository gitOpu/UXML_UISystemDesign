using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class SampleTestEvent : VisualElement
{
    VisualElement container;
    public new class UxmlFactory : UxmlFactory<SampleTestEvent, UxmlTraits> { }
    public SampleTestEvent()
    {
        RegisterCallback<GeometryChangedEvent>(OnGeometryChange);
        //RegisterCallback<AttachToPanelEvent>(OnAttach);
    }
    void OnGeometryChange(GeometryChangedEvent evt)
    {
        container = this.Q<VisualElement>("container");
        Animate_SignUpPanelIn();
        //this.UnregisterCallback<GeometryChangedEvent>(OnGeometryChange);
    }
    private void Animate_SignUpPanelIn()
    {
        if (container == null) return;
        container.transform.position = new Vector2(0, 1000);
        container.experimental.animation.Position(new Vector2(0, 0), 500).OnCompleted(() =>
        {
           Debug.Log("Finished Animate_SignUpPanelIn");
        });
    }
    private void Animate_SignUpPanelOut()
    {
        if (container == null) return;
        container.transform.position = new Vector2(0, 0);
        container.experimental.animation.Position(new Vector2(0, 1000), 1000).OnCompleted(() =>
        {
           
        });
    }
    
   
    /*
     *   private void OnAttach(AttachToPanelEvent evt)
    {
    UnregisterCallback<AttachToPanelEvent>(OnAttach);
        RegisterCallback<DetachFromPanelEvent>(OnDetach);
    }
    private void OnDetach(DetachFromPanelEvent evt)
    {
        UnregisterCallback<DetachFromPanelEvent>(OnDetach);
        RegisterCallback<AttachToPanelEvent>(OnAttach);
    }
    
     */

 
    
}
