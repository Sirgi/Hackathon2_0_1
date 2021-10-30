using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static event System.Action OnValueChanged;
    private static int _value = 0;
    private static int _record = 0;
    private static Score _instance;

    public static int Value
    {
        get
        {
            return _value;
        }

        set
        {
            _value=value;
            OnValueChanged?.Invoke();
            Record=(_record<_value)?_value:_record;
        }
    }

    public static int Record { get => _record; private set => _record = value; }

    private void Awake()
    {
        if(_instance)
        {
            if(_instance!=this)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            _instance=this;
            DontDestroyOnLoad(gameObject);
        }
        Value=0;
    }
}
