using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Buttons : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsMenuPanel;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
    }
    public void ShowMainMenuPanel()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
    }
    public void ShowSettingsMenuPanel()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
