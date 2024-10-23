using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FranceEnemy : MonoBehaviour
{
    [SerializeField] private int healFranceEnemy;
    public GameObject player;
    [SerializeField] private float speedFranceEnemy;
   // private float _distance;
    // Start is called before the first frame update
    void Start()
    {
        healFranceEnemy = 3;       
        speedFranceEnemy = 3f;
        player = GameObject.FindWithTag("Tank");
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemyFollowPlayer();
    }

    // Logic collied of FracneEnemy when enemy colliedd with bullet
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            healFranceEnemy--;
            if (healFranceEnemy == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void moveEnemyFollowPlayer()
    {
        //_distance = Vector2.Distance(transform.position, player.transform.position);
        //Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speedFranceEnemy * Time.deltaTime);
    }
}
