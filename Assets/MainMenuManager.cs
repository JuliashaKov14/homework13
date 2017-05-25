using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {
    public GameObject _panel = null;

	public bool PanelForAbout = false;
	public void Settings()
	{
		
	}

	public void GamePlay()
	{
		SceneManager.LoadScene ("Game Scena");
	}

	private void About()
	{
        if (_panel = null)
        {
            _panel.SetActive(PanelForAbout);
        }
    }
	private void close_panel(){
        PanelForAbout = false;
        _panel.SetActive(PanelForAbout);
        // onClick.button ("close") = PanelForAbout.setActive (false);
    }

		
}
