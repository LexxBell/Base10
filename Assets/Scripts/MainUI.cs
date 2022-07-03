using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{
    public TMP_InputField inputField;
    Main mainController;
    BinaryPrompt binaryPrompt;
    private int binaryNum;
    // Start is called before the first frame update
    void Start()
    {
        binaryPrompt = this.GetComponent<BinaryPrompt>();
    }

    public int startTurn()
    {
        binaryNum = binaryPrompt.SetPrompt();
        inputField.Select();
        return binaryNum;
    }


}
