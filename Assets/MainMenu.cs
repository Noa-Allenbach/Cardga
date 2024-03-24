using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class MainMenu : MonoBehaviour
{
    
    //public Canvas sel; // Reference to the canvas where buttons will be created
    public GameObject testPlayerButtonPrefab; // Reference to the button prefab

    public string scriptsFolderPath; // Folder path containing the scripts
    public string scriptsSceneName; // Name of the scene containing the scripts

    public void PlayGame()
    {
        scriptsSceneName = "SampleScene";
        // Load the scene containing the scripts additively
        SceneManager.LoadScene(scriptsSceneName, LoadSceneMode.Additive);

        GameObject selectPlayerCanvas = GameObject.Find("SelectPlayer");
        GameObject testPlayerButtonPrefab = GameObject.Find("Test Play Button");

        if (selectPlayerCanvas == null)
        {
            Debug.LogError("selectPlayer GameObject reference is missing!");
            return;
        }

        if (testPlayerButtonPrefab == null)
        {
            Debug.LogError("testPlayerButton GameObject reference is missing!");
            return;
        }


        // Get all .cs files in the specified folder
        string scriptsFolderPath = Application.dataPath + "/skripts/Heros";
        string[] scriptFiles = Directory.GetFiles(scriptsFolderPath, "*.cs");

        foreach (string filePath in scriptFiles)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);

            // Load the prefab and instantiate it
            GameObject buttonObject = Instantiate(testPlayerButtonPrefab, selectPlayerCanvas.transform);
            buttonObject.name = fileName + "Button"; // Set button name

            // Find the text component within the button to set the text
            TextMeshProUGUI buttonText = buttonObject.GetComponentInChildren<TextMeshProUGUI>();
            if (buttonText != null)
            {
                buttonText.text = fileName;
            }
            else
            {
                Debug.LogWarning("No Text component found in the button prefab.");
            }

            // Add a click listener to the button
            Button buttonComponent = buttonObject.GetComponent<Button>();
            if (buttonComponent != null)
            {
                buttonComponent.onClick.AddListener(() => OnScriptButtonClicked(fileName));
            }
            else
            {
                Debug.LogWarning("No Button component found in the button prefab.");
            }
        }
    }

    void OnScriptButtonClicked(string scriptName)
    {
        Debug.Log("Script button clicked: " + scriptName);
        // Add your logic here for what should happen when a script button is clicked
    }
}
