using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemySystem : MonoBehaviour
{
    public GameObject franceEnemy;
    private double _timer;
    private int count = 0;
    public Vector2[] listSpawnPoint = new Vector2[4];
    private bool signalFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        _timer = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 1.5 && signalFlag) 
        {
            spawnEnemy();
            count++;
            _timer = 0;
            if (count == 5)
            {
                signalFlag = false;
            }
        }
    }

    public void spawnEnemy()
    {
        Instantiate(franceEnemy, listSpawnPoint[Random.Range(0, 3)], Quaternion.identity);
    }
}
