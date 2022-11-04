using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    private RectTransform _slotRect;
    private RectTransform _dragRect;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null) return;
        
        _slotRect = GetComponent<RectTransform>();
        _dragRect = eventData.pointerDrag.GetComponent<RectTransform>();
        
        // lock the dragged item into the slot via setting anchored positions equal
        _dragRect.anchoredPosition = _slotRect.anchoredPosition;
    }
}
