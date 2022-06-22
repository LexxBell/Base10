using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main : MonoBehaviour
{
    private int binaryNum;
    private int decimalNum;
    BinaryPrompt binaryPrompt;
    BinaryToDecimal binaryToDec;
    // Start is called before the first frame update
    void Start()
    {
        binaryPrompt = this.GetComponent<BinaryPrompt>();
        binaryToDec = this.GetComponent<BinaryToDecimal>();
        binaryNum = binaryPrompt.SetPrompt();
        decimalNum = binaryToDec.ConvertToDec(binaryNum);
        Debug.Log(decimalNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
