using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _text;
    private Score _score;

    private void Awake()
    {
       _score = GameObject.FindWithTag("ScoreManager").GetComponent<Score>();
    }

    void Update()
    {
        _text.text = _score.PlayersScore.ToString();
    }
}
