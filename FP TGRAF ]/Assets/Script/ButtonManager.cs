using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	public void ToCredit()
	{
		SceneManager.LoadScene("Credit");	
	}
	public void ToMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	public void ToOption()
	{
		SceneManager.LoadScene("Options");
	}
	public void ToHelp()
	{
		SceneManager.LoadScene("Help");
	}
	public void ExitButton()
	{
		Application.Quit();
	}
}