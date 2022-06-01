using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [HideInInspector] int score;

    private void SetText()
    {
        scoreText.text = "Score: " + score;
    }

    void Start()
    {
        SetText();
    }

    public void AddScore()
    {
        score++;
        SetText();
    }
}