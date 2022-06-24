using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //singleton
    static public UIManager instance;

    public GameObject btnGameOver;

    private void Awake()
    {
        //sigleton
        UIManager.instance = this;

        btnGameOver = GameObject.Find("btnGameOver");
        btnGameOver.SetActive(false);
    }
}
