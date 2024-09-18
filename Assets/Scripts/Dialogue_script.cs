using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Dialogue_script : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    const string FILE_DIR = "/Data/";
    const string FILE_NAME = "dialogue.txt";
    string FILE_PATH;
    string[] dialogueArray;
    int dialogueIndex;

    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;

        if (File.Exists(FILE_PATH))
        {
            Debug.Log("File exists");
            dialogueArray = File.ReadAllLines(FILE_PATH);

        }
        else
        {
            Debug.Log("Something went wrong: " + FILE_PATH);
        }
        //DebugArray();
        dialogueIndex = 1;
        dialogueText.text = dialogueArray[dialogueIndex];
    }
    void DebugArray()
    {
        string message = "";
        for (int i = 1; i < dialogueArray.Length; i++)
        {
            message += dialogueArray[i].ToString() + "\t\t";
        }

        //foreach(string line in dialgoueArray)
        //{
        //    message += line + "\n";
        //}

        Debug.Log(message);
    }
    public void PressNext()//Click NextBtn to show the next line of text
    {
        dialogueIndex ++;
        if (dialogueIndex < dialogueArray.Length)
        {
            dialogueText.text = dialogueArray[dialogueIndex];
        }
        else
        {
            Debug.Log("Reached the end of the convo.");
        }
    }

}
