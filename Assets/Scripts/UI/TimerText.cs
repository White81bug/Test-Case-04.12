using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _text;
    private Timer _timer;

    private void Awake()
    {
        _timer = GameObject.FindWithTag("Timer").GetComponent<Timer>();
    }

    void Update()
    {
        _text.text = _timer.time.ToString( "0.0");
    }
}
