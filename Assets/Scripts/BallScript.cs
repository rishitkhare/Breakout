using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D Rb2D = gameObject.AddComponent<Rigidbody2D>();
        Rb2D.gravityScale = 0;
        Rb2D.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        this.transform.position = new Vector3(0, 0, 0);
        Rb2D.velocity = new Vector2(0, -3);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
