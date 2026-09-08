using UnityEngine;
using UnityEngine.EventSystems;

public class MouceGard : MonoBehaviour
{

    public void OnPointerEnter(PointerEventData eventData)
    {
        EventSystem.current.SetSelectedGameObject(null);
    }
}

