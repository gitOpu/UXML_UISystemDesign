using UnityEngine.UIElements;

 
public abstract class Panel : VisualElement
{
    #region CONSTRUCTOR
    public Panel() => Initialise();
    #endregion
 
    #region PRIVATE METHODS
    private void Initialise()
    {
        RegisterCallback<AttachToPanelEvent>(OnAttach);
        Set(this);
    }
    #endregion
 
    #region EVENT HANDLERS
    protected virtual void OnAttach(AttachToPanelEvent evt)
    {
       
        UnregisterCallback<AttachToPanelEvent>(OnAttach);
        RegisterCallback<DetachFromPanelEvent>(OnDetach);
    }
    protected virtual void OnDetach(DetachFromPanelEvent evt)
    {
       
        UnregisterCallback<DetachFromPanelEvent>(OnDetach);
        RegisterCallback<AttachToPanelEvent>(OnAttach);
    }
    #endregion
 
    #region PRIVATE STATIC METHODS
    private static void Set(VisualElement element)
    {    
        //SetStyleSheet(element);
       // element.AddToClassList(CoreUIUSS.PANEL_ABSOLUTE);
    }
    #endregion
}