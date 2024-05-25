using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // If player goes through pipe then call add score to increase score by 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collison that happened is on the object of the birds layer
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
