using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class UIControl : MonoBehaviour
{
    [SerializeField] private UIDocument uiDocument;
    [SerializeField] private PlayerData[] playerData;
    [SerializeField] private InputManager input;
    private VisualElement equipInfoBox, charaInfoBox;

    private void Awake()
    {
        charaInfoBox = uiDocument.rootVisualElement.Q<VisualElement>("charaInfo");
        equipInfoBox = uiDocument.rootVisualElement.Q<VisualElement>("equipSlot");
        input.indexChange += changeForm;
    }

    public void changeForm(int index)
    {
        charaInfoBox.dataSource = playerData[index];
        equipInfoBox.dataSource = playerData[index];    
    }
}
