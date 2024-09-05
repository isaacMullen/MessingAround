using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class LetterSpawner : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    public string message;
    private string newMessage = "";

    private int index;
    int alphabetIndex;
    
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.!";
    // Start is called before the first frame update
    
    
    void Start()
    {               
        Invoke("SpawnLetter", 1f);        
    }

    // Update is called once per frame
    void SpawnLetter()
    {
        try
        {        
            alphabetIndex++; 
            text.SetText(newMessage + alphabet[alphabetIndex].ToString());
            
            
            if(alphabet[alphabetIndex] == message.ToUpper()[index])
            {        
                newMessage += message[index];
                index++;
                alphabetIndex = 0;
                Debug.Log("SAME LETTER");
            }
            
            else if(message[index].ToString() == " ")
            {
                newMessage += message[index].ToString();
                index++;
                alphabetIndex = 0;
                Debug.Log("SPACE DETECTED");            
            }
            
            else if(message[index].ToString().ToUpper() == "A")
            {
                newMessage += message[index].ToString();
                index++;
                alphabetIndex = 0;
                Debug.Log("SPACE DETECTED");            
            }
            
            if(newMessage.Length != message.Length)
            {
                Invoke("SpawnLetter", .0175f);
            }
            
        }
        
        catch(IndexOutOfRangeException)
        {
            return;
        }
              
    }
}
