using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Converts a binary number to decimal */

public class BinaryToDecimal : MonoBehaviour
{
 
    public int ConvertToDec(int bin) {
        int dec = 0;
        int base1 = 1;
            
            while (bin > 0)
            {
                int remainder = bin % 10;
                bin = bin / 10;
                dec += remainder * base1;
                base1 = base1 * 2;
            }
        return dec; 
    }
}
