using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    public List<Transform> GameOverToEnable;
    public List<Transform> GameOverToDisable;

    public int Score { get; private set; }


    // Use this for initialization
    void Start ()
	{
	    player.OnDeath += PlayerDied;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlayerDied()
    {
        foreach ( var obj in GameOverToEnable ) 
            obj.gameObject.SetActive(true);


        foreach (var obj in GameOverToDisable)
            obj.gameObject.SetActive(false);
    }

    public void AddPoints(int points)
    {
        Score += points;
    }

    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
