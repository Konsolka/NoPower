using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextLevel : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void exitToMenu()
	{
		SceneManager.LoadScene(0);
	}
	public void LoadLevel(int level)
	{
		SceneManager.LoadScene(level);
	}
}
