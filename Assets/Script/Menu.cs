using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void Game()
	{
		SceneManager.LoadScene("Stone"); // в двойных кавычках пишите имя вашей сцены(где ваша игра)
	}

	public void Game2()
	{
		SceneManager.LoadScene("New year"); // в двойных кавычках пишите имя вашей сцены(где ваша игра)
	}

	public void Snow()
	{
		SceneManager.LoadScene("Snow"); // в двойных кавычках пишите имя вашей сцены(где ваша игра)
	}

	public void Game3()
	{
		SceneManager.LoadScene("Halloween"); // в двойных кавычках пишите имя вашей сцены(где ваша игра)
	}


	public void Back()
	{
		SceneManager.LoadScene("Menu"); // в двойных кавычках пишите имя вашей сцены(где ваше меню)
	}

	public void ExitGame() //выход из игры 
	{
		Application.Quit();
		Debug.Log("Exit");
	}
}



