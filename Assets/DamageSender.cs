using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    //create link EnemyCtrl
    protected EnemyCtrl enemyCtrl;

    private void Awake()
    {
        enemyCtrl = GetComponent<EnemyCtrl>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        damageReceiver.Receive(1);

        this.enemyCtrl.despawner.Despawn();
    }
}
