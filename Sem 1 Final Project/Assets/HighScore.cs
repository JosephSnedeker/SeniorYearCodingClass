using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour {
    public Text score;
    public Text highScore;
	// Use this for initialization
	void Start () {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); ;
	}
	
	// Update is called once per frame
	void Update () {
        int gamescore = GameManager.Instance.MyCharacter.score;
        
        score.text = gamescore.ToString();
        if (gamescore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", gamescore);
            highScore.text = gamescore.ToString();
        }
        
	}
}
