using UnityEngine;

public class ReelManager : MonoBehaviour
{
    public int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (reelSpin.main.spinCounter >= reelSpin.main.spinMaxCounter)
        {
            speed = 0; // Stop the reels
        }

        if (reelSpin.main.isSpinning)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (transform.position.y <= -0.63f)
        {
            transform.position = new Vector3(transform.position.x, 2.38f, 0);
        }
    }
}
