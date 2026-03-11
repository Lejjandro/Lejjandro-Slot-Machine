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
        spinMaxCounter = Random.Range(0, 20);
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
