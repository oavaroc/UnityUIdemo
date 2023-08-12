using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup[] _menus;
    private int _currentMenuIndex = 0;

    private void Start()
    {
        SwitchMenu(_currentMenuIndex);
    }

    public void SwitchMenu(int newIndex)
    {
        _menus[_currentMenuIndex].interactable = false;
        _menus[_currentMenuIndex].blocksRaycasts = false;
        _menus[_currentMenuIndex].alpha = 0;

        _currentMenuIndex = newIndex;

        _menus[_currentMenuIndex].interactable = true;
        _menus[_currentMenuIndex].blocksRaycasts = true;
        _menus[_currentMenuIndex].alpha = 1;

        EventSystem.current.SetSelectedGameObject(_menus[_currentMenuIndex].transform.GetChild(0).GetChild(0).gameObject);
    }
}
