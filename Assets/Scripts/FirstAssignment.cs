using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAssignment : MonoBehaviour
{
    public int numberOne = 20;
    public int numberTwo = 5;
    public int numberThree = 30;
    public int numberFour = 2;
    public int numberFive = 10;

    public float result;

    public string sentence = "the result is ";


    // Start is called before the first frame update
    void Start()
    {

        result = (numberOne + numberTwo + numberThree + numberFour + numberFive) / 3f;

        Debug.Log(result);

        Debug.Log(sentence + result);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
