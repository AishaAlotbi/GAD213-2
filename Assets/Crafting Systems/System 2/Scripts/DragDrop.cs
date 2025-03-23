using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler
{
   public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("on pointer down");
    }
}
