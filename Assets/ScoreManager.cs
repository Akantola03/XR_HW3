using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        scoreText.text = "Score: " + score;
    }
}
