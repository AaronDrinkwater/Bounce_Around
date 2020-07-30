using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour
{
    public GameObject ball;

    public float speed = 5.0f;

    public bool is_spawned;

    public int num_of_balls;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && is_spawned == false)
        {
            GameObject instantiate_bullet = Instantiate(ball, transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D instantiate_rigidbody = instantiate_bullet.GetComponent<Rigidbody2D>();
            instantiate_rigidbody.AddForce(Vector2.down);

            is_spawned = true;

            if (ball == null)
            {
                is_spawned = false;
                ball = instantiate_bullet;
               
            }
        }
    }
}



