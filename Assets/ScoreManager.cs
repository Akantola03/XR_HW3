using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public static int score;
    public TextMeshProUGUI scoreText;
    //public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
        UpdateScoreUI();
    }

    private void Awake()
    {
        Instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int amount) 
    {
        score += amount;
        UpdateScoreUI();
        //scoreText.text = "Score: " + score;
    }

    void UpdateScoreUI() 
    {
        scoreText.text = "Your Score: " + score.ToString();
    }
}
