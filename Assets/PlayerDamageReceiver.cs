using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver //Inheritance
{
    //create link PlayerCtrl
    protected PlayerCtrl playerCtrl;

    private void Awake()
    {
        this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Receive(int damage)
    {
        base.Receive(damage);

        if (this.isDead())
        {
            this.playerCtrl.playerStatus.Dead();
            UIManager.instance.btnGameOver.SetActive(true);
        }
    }
}
