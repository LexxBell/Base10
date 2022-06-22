using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using TMPro;


public class BinaryPrompt : MonoBehaviour {
    /*

        Gets binary numbers from txt file
        to prompt to the user

    */

    private int bin;
    public TextAsset TextFile;
    List<string> binArr = new List<string>();
    public TextMeshProUGUI prompt;

    void Awake() {
        GetBinaryNumber();
    }
    public void GetBinaryNumber() {
        /* Add binary in the binNumbers.txt file */
        string[] lines = TextFile.text.Split('\n');

        foreach (string line in lines) {
            binArr.Add(line);
        }
    }

    /* Prompts the binary number & returns it as an int */
    public int SetPrompt() {
        string bin = binArr[UnityEngine.Random.Range(0, binArr.Count)];
        prompt.text = bin;
        return Convert.ToInt32(bin);
    }

    public void removePrompt() {
        prompt.text = "";
    }

}
