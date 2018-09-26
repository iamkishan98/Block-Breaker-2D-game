using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name)
    {
        Debug.Log("the new level is:"+name);
        SceneManager.LoadScene(name);
    }
    public void QuitRequest()
    {
    	Debug.Log("quit the Game");
    	Application.Quit();
    }
    public void LoadNextLevel ()
	{
		SceneManager.LoadScene(Application.loadedLevel + 1);
	}
	public void BricksDestroyed ()
	{
		if (Bricks.breakcount <= 0) {
			Debug.Log ("All Bricks has been Destroyed");
			LoadNextLevel ();
		}
	}
}
