//using System.Collections;
//using System.Collections.Generic; 
using UnityEngine;
using Unity.Mathematics;

public class MoveBullet : MonoBehaviour
{
    [SerializeField] private float speedBullet;
    // Start is called before the first frame update
    void Start()
    {
        speedBullet = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        moveBullet();
        logicBullet();
    }

    public void moveBullet()
    {
        transform.Translate(Vector3.up * speedBullet * Time.deltaTime);
    }

    public void logicBullet()
    {
        if (math.abs(transform.position.x) > 12 || math.abs(transform.position.y) > 8)
        {
            Destroy(gameObject);
        }
    }

}
