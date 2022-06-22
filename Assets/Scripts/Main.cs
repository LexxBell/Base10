using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main : MonoBehaviour
{
    private int binaryNum;
    BinaryPrompt binaryPrompt;
    // Start is called before the first frame update
    void Start()
    {
        binaryPrompt = this.GetComponent<BinaryPrompt>();
        binaryPrompt.SetPrompt();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
