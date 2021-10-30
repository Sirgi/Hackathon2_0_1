using UnityEngine;

public class GhostPower : MonoBehaviour
{
    public static event System.Action OnValueChanged;
    private static float _value = 0f;

    public static float Value
    {
        get
        {
            return _value;
        }

        set
        {
            _value=value;
            if(_value<0f)
            {
                _value=0f;
            }
            OnValueChanged?.Invoke();
        }
    }

    private void Awake()
    {
        Value=0;
    }
}
