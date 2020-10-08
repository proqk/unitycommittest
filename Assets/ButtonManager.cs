using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //--------------------------------------------Main
    public void Main_ok_Button() //메인-좋아요
    {
        GameObject.Find("Canvas").transform.FindChild("gray").gameObject.SetActive(true); //set gray bg image
        GameObject.Find("Canvas").transform.FindChild("처리").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("거절").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("스캔").gameObject.SetActive(true);

        GameObject IDcardobj = GameObject.Find("신분증");
        RectTransform rectTran = IDcardobj.GetComponent<RectTransform>();
        Vector3 position = IDcardobj.transform.localPosition;
        rectTran.SetAsLastSibling(); //IDcard to the top

        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 940); //IDcard Size
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 530); //IDcard Size
        position.x = 0;
        position.y = 0;
        IDcardobj.transform.localPosition = position;
    }

    public void Main_refuse_button() //메인-거절
    {
        GameObject IDcardobj = GameObject.Find("신분증");
        RectTransform rectTran = IDcardobj.GetComponent<RectTransform>();
        Vector3 position = IDcardobj.transform.localPosition;
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 228);
        rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 101);
        position.x = -41;
        position.y = -309;
        IDcardobj.transform.localPosition = position;
        GameObject.Find("Canvas").transform.FindChild("gray").gameObject.SetActive(false);
    }
    public void Main_accept_button() //메인-수락
    {
        SceneManager.LoadScene("Table");
    }
    public void Main_scan_button() //메인-스캔
    {
        Debug.Log("스캔");
    }
    public void Main_to_Phone() //메인-전화기
    {
        SceneManager.LoadScene("Phone");
    }
    public void Main_to_Messenger() //메인-메신저
    {
        SceneManager.LoadScene("Messenger");
    }

    //--------------------------------------------Table
    public void Table_to_Main()
    {
        SceneManager.LoadScene("Main");
    }
    bool isBig = true;
    public void Table_account_slip_Button()
    {
        GameObject accobj = GameObject.Find("통장");
        GameObject slipobj = GameObject.Find("전표");
        RectTransform rectaccobj = accobj.GetComponent<RectTransform>();
        RectTransform rectslipobj = slipobj.GetComponent<RectTransform>();
        Vector3 positionacc = accobj.transform.localPosition;
        Vector3 positionslip = slipobj.transform.localPosition;

        rectaccobj.SetAsLastSibling(); //acc to the top
        rectslipobj.SetAsLastSibling(); //slip to the top

        if (isBig)
        {
            rectaccobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 830); //acc
            rectaccobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 530); //acc
            rectaccobj.transform.localPosition = new Vector3(-470,10,0);

            rectslipobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 830); //slip
            rectslipobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 530); //slip
            rectslipobj.transform.localPosition = new Vector3(470, 10, 0);

            isBig = false;
        }
        else
        {
            rectaccobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 630); //acc
            rectaccobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 330); //acc
            rectaccobj.transform.localPosition = new Vector3(100, 230, 0);

            rectslipobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 630); //slip
            rectslipobj.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 330); //slip
            rectslipobj.transform.localPosition = new Vector3(100, -150, 0);

            isBig = true;
        }
    }
    public void Table_deposit_botton() //테이블-입금
    {
        GameObject.Find("Canvas").transform.FindChild("gray").gameObject.SetActive(true); //set gray bg image
        GameObject.Find("Canvas").transform.FindChild("처리").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("거절").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("오만").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("만").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("오천").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("천").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.FindChild("총합").gameObject.SetActive(true); //for문라도 묶어야 하나 이건 아닌 것 같은데
    }
    public void Table_add_fiftyt() //테이블-오만
    {
        int num = int.Parse(GameObject.Find("총합").gameObject.GetComponent<Text>().text);
        num += 50000;
        GameObject.Find("총합").gameObject.GetComponent<Text>().text = num.ToString();
    }
    public void Table_add_tent() //테이블-만
    {
        int num = int.Parse(GameObject.Find("총합").gameObject.GetComponent<Text>().text);
        num += 10000;
        GameObject.Find("총합").gameObject.GetComponent<Text>().text = num.ToString();
    }
    public void Table_add_fivet() //테이블-오천
    {
        int num = int.Parse(GameObject.Find("총합").gameObject.GetComponent<Text>().text);
        num += 5000;
        GameObject.Find("총합").gameObject.GetComponent<Text>().text = num.ToString();
    }
    public void Table_add_onet() //테이블-천
    {
        int num = int.Parse(GameObject.Find("총합").gameObject.GetComponent<Text>().text);
        num += 1000;
        GameObject.Find("총합").gameObject.GetComponent<Text>().text = num.ToString();
    }
    public void Table_accept_button() //테이블-처리
    {
        GameObject.Find("총합").SetActive(false);
        GameObject.Find("처리").SetActive(false);
        GameObject.Find("거절").SetActive(false);
        GameObject.Find("오만").SetActive(false);
        GameObject.Find("만").SetActive(false);
        GameObject.Find("오천").SetActive(false);
        GameObject.Find("천").SetActive(false);
        GameObject.Find("gray").SetActive(false); //이렇게 중복되는 거 나중에 리스트에 박고 for문으로 수정해야..
    }
    public void Table_refuse_button() //테이블-거절
    {
        GameObject.Find("총합").SetActive(false);
        GameObject.Find("처리").SetActive(false);
        GameObject.Find("거절").SetActive(false);
        GameObject.Find("오만").SetActive(false);
        GameObject.Find("만").SetActive(false);
        GameObject.Find("오천").SetActive(false);
        GameObject.Find("천").SetActive(false);
        GameObject.Find("gray").SetActive(false); //이렇게 중복되는 거 나중에 리스트에 박고 for문으로 수정해야..
    }
    public void Table_withdraw_botton()
    {

    }
}
