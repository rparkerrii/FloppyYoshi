#if UNITY_EDITOR
using UnityEditor.Build;
#endif
using UnityEngine;

public class YoshiScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    // When space bar is pressed and the bird is alive, it will make the bird move up based on flap strength
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myRigidBody2D.velocity = Vector2.up * flapStrength;
        }
    }

    // When the bird collides with an object it will run game over screen and change the birdisalive to false to stop user interactions on bird once dead.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}