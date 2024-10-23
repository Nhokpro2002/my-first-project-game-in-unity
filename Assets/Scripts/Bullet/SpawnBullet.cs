//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{

    [SerializeField] private GameObject bulletInstance;
    [SerializeField] private Transform gun;
    //[SerializeField] private GameObject gun;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnBullet();
    }

    public void spawnBullet()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletInstance, gun.position, gun.rotation);
            
        }
    }
}
