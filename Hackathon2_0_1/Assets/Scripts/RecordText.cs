using UnityEngine;
using UnityEngine.UI;

public class RecordText : MonoBehaviour
{
    [SerializeField] private Text _text;
    private void Start()
    {
        _text.text=Score.Record.ToString();
    }
}
