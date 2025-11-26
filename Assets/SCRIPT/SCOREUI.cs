using UnityEngine;
using TMPro;

public class SCOREUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    internal void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }













}
