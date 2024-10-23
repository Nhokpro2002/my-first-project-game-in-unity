using Unity.Mathematics;
using UnityEngine;

public class ControllLogicBullet : MonoBehaviour
{
    //[SerializeField] private GameObject bulletInstance;
    // Start is called before the first frame update    

    // Update is called once per frame
    void Update()
    {
        deleleBulletOutOfRange();
    }

    public void deleleBulletOutOfRange()
    {
        if (math.abs(transform.position.x) > 12 || math.abs(transform.position.y) > 8)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {           
            Destroy(gameObject);
        }
    }

}
