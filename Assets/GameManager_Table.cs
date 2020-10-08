using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Table : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("gray").SetActive(false);

        //----입금
        GameObject.Find("총합").SetActive(false);
        GameObject.Find("처리").SetActive(false);
        GameObject.Find("거절").SetActive(false);
        GameObject.Find("오만").SetActive(false);
        GameObject.Find("만").SetActive(false);
        GameObject.Find("오천").SetActive(false);
        GameObject.Find("천").SetActive(false);

        //----출금

    }

    // Update is called once per frame
    void Update()
    {

    }
}
