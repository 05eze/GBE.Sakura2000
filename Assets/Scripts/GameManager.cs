using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{

    public AudioSource theMusic;
    
    public bool startPlaying;
    
    public BeatScroller theBS;
    
    public static GameManager instance;

	public int currentScore;
	public int scorePerNote = 100;
	public int scorePerGoodNote = 125;
	public int scorePerPerfectNote = 150;


	public Text scoreText;
	public Text multiText;
	
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

		scoreText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
		{
			if(Input.anyKeyDown)
			{
				startPlaying = true; 
				theBS.hasStarted = true;

				theMusic.Play();
			}
		}
    }


	public void NoteHit()
	{
		Debug.Log("Hit On Time");

		//currentScore += scorePerNote;
		scoreText.text = " " + currentScore;
	}

	public void NormalHit()
    {
		currentScore += scorePerNote;
		NoteHit();
    }

	public void GoodHit()
    {
		currentScore += scorePerGoodNote;
		NoteHit();
    }

	public void PerfectHit()
    {
		currentScore += scorePerPerfectNote;
		NoteHit();
    }

	public void NoteMissed()
	{
		Debug.Log("Missed Note");	
	}
}
