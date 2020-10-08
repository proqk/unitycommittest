using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_game_button : MonoBehaviour
{
    public float notespeed = 400f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.localPosition += Vector3.down * notespeed * Time.deltaTime;
        
    }
}
