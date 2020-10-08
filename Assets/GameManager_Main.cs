using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("gray").SetActive(false);
        GameObject.Find("스캔").SetActive(false);
        GameObject.Find("처리").SetActive(false);
        GameObject.Find("거절").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
