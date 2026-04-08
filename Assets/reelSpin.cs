using UnityEngine;

public class reelSpin : MonoBehaviour
{
    public static reelSpin main;
    public bool isSpinning;
    public int spinCounter;
    public int spinMaxCounter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        main = this;
        isSpinning = true;
        // Set a random maximum spin count between 50 and 100
        // Ställ in ett slumpmässigt maximalt antal snurr mellan 50 och 100
        spinMaxCounter = Random.Range(50, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if(spinCounter >= spinMaxCounter)
        {
            isSpinning = false;
        }
        else
        {
            isSpinning = true;
        }
    }
}
