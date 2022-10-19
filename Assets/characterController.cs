using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    // Variables
    public float speed = 5f;
    Vector2 targetPosition;
    Vector2 direction;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        manageMovements();
        manageOrientation();
    }

    void manageMovements(){
        if(Input.GetMouseButton(0)){
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            direction = new Vector2(targetPosition.x - transform.position.x, targetPosition.y - transform.position.y);
            direction.Normalize();

            Vector2 velocity = direction * speed;

            rb.velocity = velocity;
        }
        else{
            rb.velocity = Vector2.zero;
        }
    }

    void manageOrientation(){
        transform.localScale = new Vector2(direction.x > 0 ? 1 : -1, transform.localScale.y);
    }
}
