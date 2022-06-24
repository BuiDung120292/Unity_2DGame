using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    protected GameObject enemyPrefab;

    protected float spawnTimer = 0f;
    protected float spawnDelay = 2f;


    private void Awake()
    {
        this.enemyPrefab = GameObject.Find("EnemyPrefab");
        this.enemyPrefab.SetActive(false);

    }

    private void Update()
    {
        this.Spawn();
    }

    public virtual void Spawn()
    {
        if (PlayerCtrl.instance.damageReceiver.isDead()) return;
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;

        GameObject enemy = Instantiate(this.enemyPrefab);
        enemy.transform.position = transform.position;
        enemy.SetActive(true);
    }
}
