using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Text _text;
    private void Start()
    {
        UpdateText();
        Score.OnValueChanged+=UpdateText;
    }

    private void UpdateText()
    {
        _text.text=Score.Value.ToString();
    }

    private void OnDestroy()
    {
        Score.OnValueChanged-=UpdateText;
    }
}
