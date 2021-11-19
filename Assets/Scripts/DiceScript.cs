using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public int result;
    public int luckyNumberOne = 4;
    public int luckyNumberTwo = 8;
    public int luckyNumberThree = 12;
    public string luckyNumberText = "win! Your lucky Number is ";

    // Start is called before the first frame update
    void Start()
    {
        Dice();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Dice();
        }

    }

    void Dice() 
    {
        result = Random.Range(1, 21);
        // Debug.Log(result);

        if (result == luckyNumberOne || result == luckyNumberTwo || result == luckyNumberThree)
        {
            Debug.Log(luckyNumberText + result);
        }

        else
        {
            Debug.Log(result + " you lost!");
        }

    }



}
