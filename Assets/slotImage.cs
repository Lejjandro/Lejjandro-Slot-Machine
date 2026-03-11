using UnityEngine;

public class slotImage : MonoBehaviour
{

    public int speed = 5; // Speed at which the image moves downwards

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (reelSpin.main.isSpinning)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime); // Move the image downwards at the specified speed
        }


        if (transform.position.y <= -1.6f)
        {
            transform.position = new Vector3(transform.position.x,1.6f,0); // Reset the position of the image to the top when it reaches a certain point
            reelSpin.main.spinCounter++; // Increment the spin counter in the reelSpin script
        }
    }
}
