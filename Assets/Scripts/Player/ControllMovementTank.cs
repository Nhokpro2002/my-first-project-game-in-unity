//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ControllMovevement : MonoBehaviour
{

    private float speedTank;
    private Vector3 initialDirection;
    // Start is called before the first frame update
    void Start()
    {
        speedTank = 5f;
        initialDirection = Vector3.up;
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        rotation();
    }

    public void movement()      
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * speedTank * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * speedTank * Time.deltaTime;    

        Vector3 moveDirection = (Vector3.right * moveHorizontal) + (initialDirection * moveVertical);

        // update position tank
        transform.position += moveDirection;
    }

    public void rotation()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 dirction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = dirction;
    }
}
