using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCode : MonoBehaviour
{
    int intToSave;
    int numRunes;
    //float floatToSave;
    //string stringToSave;
    public GUIContent saveBtn;
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 125, 50), "Raise Integer"))
            intToSave++;
        //if (GUI.Button(new Rect(0, 100, 125, 50), "Raise Float"))
        // floatToSave += 0.1f;
        //stringToSave = GUI.TextField(new Rect(0, 200, 125, 25),
        // stringToSave, 15);
        GUI.Label(new Rect(0, 0, 150, 50), "Integer value is "
                   + intToSave);
        // GUI.Label(new Rect(0, 200, 125, 50), "Float value is "
        //+floatToSave.ToString("F1"));
        //GUI.Label(new Rect(0, 250, 125, 50), "String value is "
        //    + stringToSave);
        if(GUI.Button(new Rect(0,200,125,50),saveBtn)){ 
        SaveGame(); }
        if (GUI.Button(new Rect(0, 350, 125, 50),
                    "Load Your Game"))
            LoadGame();
        if (GUI.Button(new Rect(0, 400, 125, 50),
                    "Reset Save Data"))
            ResetData();
    }
    void SaveGame()
    {
        PlayerPrefs.SetInt("SavedInteger", intToSave);
        PlayerPrefs.SetInt("numRunes", numRunes);
        //PlayerPrefs.SetFloat("SavedFloat", floatToSave);
        //PlayerPrefs.SetString("SavedString", stringToSave);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            intToSave = PlayerPrefs.GetInt("SavedInteger");
            numRunes = PlayerPrefs.GetInt("numRunes");
            //floatToSave = PlayerPrefs.GetFloat("SavedFloat");
            //stringToSave = PlayerPrefs.GetString("SavedString");
            Debug.Log("Game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }
    void ResetData()
    {
        PlayerPrefs.DeleteAll();
        intToSave = 0;
        numRunes = 0;
        //floatToSave = 0.0f;
        //stringToSave = "";
        Debug.Log("Data reset complete");
    }


    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
