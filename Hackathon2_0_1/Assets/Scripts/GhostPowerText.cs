using UnityEngine;
using UnityEngine.UI;

public class GhostPowerText : MonoBehaviour
{
    [SerializeField] private Text _text;
    private void Start()
    {
        GhostPower.OnValueChanged+=UpdateText;
    }

    private void UpdateText()
    {
        _text.text=GhostPower.Value.ToString();
    }

    private void OnDestroy()
    {
        GhostPower.OnValueChanged-=UpdateText;
    }
}
