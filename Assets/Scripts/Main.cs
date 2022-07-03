using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main : MonoBehaviour
{

    GameObject ui;
    private int decimalNum;
    MainUI uiController;
    private int binaryNum;
    private int score;
    private int userInput;
    GetInput input;
    
    BinaryToDecimal binaryToDec;
    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("UIController");
        uiController = ui.GetComponent<MainUI>();
        binaryToDec = this.GetComponent<BinaryToDecimal>();
        input = this.GetComponent<GetInput>();
        startRound();
    }

    public void startRound()
    {
        binaryNum = uiController.startTurn();
        decimalNum = binaryToDec.ConvertToDec(binaryNum);
        Debug.Log(decimalNum);
    }


    public void scoreKeeper()
    {
        userInput = input.getIntInput();
        Debug.Log(userInput + "      user input");
        Debug.Log(decimalNum + "   PROG INPUT");
    }
    
}
