using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2d;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) {
          rb2d.velocity = Vector2.up * velocity; 
        }
    }
}
