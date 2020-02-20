using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Buttons : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject OptionMenuPanel;
    public GameObject OptionAudioPanel;
    public GameObject OptionVideoPanel;
    public GameObject OptionControlsPanel;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuPanel.SetActive(true);
        OptionMenuPanel.SetActive(false);
        OptionAudioPanel.SetActive(false);
        OptionVideoPanel.SetActive(false);
        OptionControlsPanel.SetActive(false);
    }
    public void ShowMainMenuPanel()
    {
        MainMenuPanel.SetActive(true);
        OptionMenuPanel.SetActive(false);
        OptionAudioPanel.SetActive(false);
        OptionVideoPanel.SetActive(false);
        OptionControlsPanel.SetActive(false);
    }
    public void ShowOptionMenuPanel()
    {
        MainMenuPanel.SetActive(false);
        OptionMenuPanel.SetActive(true);
        OptionAudioPanel.SetActive(false);
        OptionVideoPanel.SetActive(false);
        OptionControlsPanel.SetActive(false);
    }
    public void ShowOptionAudio()
    {
        MainMenuPanel.SetActive(false);
        OptionMenuPanel.SetActive(true);
        OptionAudioPanel.SetActive(true);
        OptionVideoPanel.SetActive(false);
        OptionControlsPanel.SetActive(false);
    }
    public void ShowOptionVideo()
    {
        MainMenuPanel.SetActive(false);
        OptionMenuPanel.SetActive(true);
        OptionAudioPanel.SetActive(false);
        OptionVideoPanel.SetActive(true);
        OptionControlsPanel.SetActive(false);
    }
    public void ShowOptionControls()
    {
        MainMenuPanel.SetActive(false);
        OptionMenuPanel.SetActive(true);
        OptionAudioPanel.SetActive(false);
        OptionVideoPanel.SetActive(false);
        OptionControlsPanel.SetActive(true);
    }
}
