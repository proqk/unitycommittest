using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moving_idcard : MonoBehaviour, IDropHandler
{
    public GameObject idcard, targetobject;
    private float speed = 1000f;

    void Start()
    {
        int randX = UnityEngine.Random.Range(-190, 760);
        int randY = UnityEngine.Random.Range(-111, -413);
        targetobject.transform.localPosition = new Vector3(randX, randY);
    }

    void OnEnable()
    {
        StartCoroutine("UIcoroutine");
    }

    void OnDisable()
    {
        StopCoroutine("UIcoroutine");
    }

    private IEnumerator UIcoroutine()
    {
        while (true)
        {
            while (Vector3.Distance(idcard.transform.position, targetobject.transform.position) > 1f)
            {
                idcard.transform.position = Vector3.MoveTowards(idcard.transform.position, targetobject.transform.position, Time.deltaTime * speed);
                speed += 100f;
                yield return new WaitForSeconds(0.02f);
            }
            yield return new WaitForSeconds(1f);
        }

    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Debug.Log("충돌");
        }
    }
}
