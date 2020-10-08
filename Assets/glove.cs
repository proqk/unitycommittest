using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class glove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
        //Debug.Log("begin drag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Drag");
        rectTransform.anchoredPosition += eventData.delta;
    }
    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Drop");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //Debug.Log("end Drag");
    }


}
