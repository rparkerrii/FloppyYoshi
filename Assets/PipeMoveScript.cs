using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -18;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is how fast the pipes will move and we also make it move to the left
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // If the pipe hits the deadzone x axis then it will delete the pipe
        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
