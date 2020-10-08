using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_game_manager : MonoBehaviour
{
    public int bpm = 0;
    double curTime = 0d;
    
    public Transform noteFactory; //노트 공장
    public GameObject goNote; //노트

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime >= 60d / bpm) //60s/bmp=1beat시간(ex. 60/120=1beat당 0.5초)
        {
            GameObject t_note = Instantiate(goNote, noteFactory.position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            curTime -= 60d / bpm;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Note")){
            Debug.Log("없어짐");
            Destroy(collision.gameObject);
        }
    }
}
