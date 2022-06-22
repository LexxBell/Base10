using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GetInput : MonoBehaviour
{
    public string input;
    public TMP_InputField inputField;

    public string getInput()

    {   
        if (inputField.GetComponent<Text>().text != null) {
            input = inputField.GetComponent<Text>().text;
            return input;
        } else {
            return ":(";
        }

    }

}