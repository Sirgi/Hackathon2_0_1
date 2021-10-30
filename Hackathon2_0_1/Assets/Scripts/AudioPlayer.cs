using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private static AudioPlayer _instance;
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
    }
}
