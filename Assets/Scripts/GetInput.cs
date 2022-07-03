using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using TMPro;
public class GetInput : MonoBehaviour
{
    private string input;
    public TMP_InputField inputField;
    private int finalInput;

    public void getInput() 
    {


            input = inputField.GetComponent<Text>().text;
            finalInput = Convert.ToInt32(input);

    }

    public int getIntInput()
    {
        return finalInput;
    }

}