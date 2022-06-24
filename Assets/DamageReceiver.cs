using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    protected int hp = 3;

    public virtual void Receive(int damage)
    {
        this.hp -= damage;
    }

    public virtual bool isDead()
    {
        return this.hp <= 0;
    }
}
