using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // At the start of the game it will spawn a pipe.
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    // This will spawn a pipe every 2 seconds
    void Update()
    {
        if (timer < spawnRate)
        {
            //use deltaTime to not change spawn rate based on framerate
            timer += Time.deltaTime;
        }
        else
        {
            // once timer is the same number or above spawnRate then it will spawn a pipe and then start back at 0 seconds
            spawnPipe();
            timer = 0;
        }   
    }

    void spawnPipe()
    {
        // This will spawn the top and bottom pipe at random locations based on the height offset inputted
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}