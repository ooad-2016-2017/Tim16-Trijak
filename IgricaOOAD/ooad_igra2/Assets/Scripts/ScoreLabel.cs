using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLabel : MonoBehaviour
{
    public GameManager gameManager;

    public Text text;

    private string prefix = "";

	// Use this for initialization
	void Start ()
	{
	    prefix = text.text;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (!gameManager) return;

	    text.text = prefix + gameManager.Score;
	}
}
