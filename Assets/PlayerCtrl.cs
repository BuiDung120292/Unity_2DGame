using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    //clean code #1
    //code navigation #2
    //code convention #3

    //singleton
    static public PlayerCtrl instance;

    public DamageReceiver damageReceiver;
    public PlayerStatus playerStatus;

    private void Awake()
    {
        //singleton
        PlayerCtrl.instance = this;

        this.damageReceiver = GetComponent<DamageReceiver>();
        this.playerStatus = GetComponent<PlayerStatus>();
    }
}
