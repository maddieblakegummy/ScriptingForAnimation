using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	private float startTimer = 0f;
	private bool GameOver = false;

	public Text timerText;


	void Start () {
		startTimer -= Time.time;
	
	}
	

	void Update () {
		if (GameOver)
			return;

		float t = Time.time + startTimer;
		string minutes = ((int)t / 60).ToString ();
		float realseconds = (t % 60);
		string seconds = realseconds.ToString ("f2");

		timerText.text = minutes + ":" + seconds;
		if (realseconds > 59)
		{
			StartCoroutine(TimeUp());
		}
	}

	IEnumerator TimeUp()
	{
		yield return new WaitForSeconds (1);
		Application.LoadLevel ("TimesUp");
	}

	public void GameDone ()
	{
		GameOver = true;
		timerText.color = Color.red;
	}
	
}
