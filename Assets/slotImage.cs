using UnityEngine;

public class slotImage : MonoBehaviour
{

    private int speed; // Speed at which the image moves downwards
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*speed = transform.parent.GetComponent<ReelManager>().speed; // Get the speed from the ReelManager script
        if (reelSpin.main.isSpinning)
        {
            // Move the image downwards at the specified speed
            // Flytta bilden nedåt med den angivna hastigheten
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }


        if (transform.position.y <= -1.3f)
        {
            // Reset the position of the image to the top when it reaches a certain point
            // Återställ positionen för bilden till toppen när den når en viss punkt
            transform.position = new Vector3(transform.position.x,1.464f,0);
            // Increment the spin counter in the reelSpin script
            // Öka snurr räknaren i reelSpin skriptet
            reelSpin.main.spinCounter++;
        }*/
    }
}
