using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
    [SerializeField] private float _destroyTime=10f;
    
    private void Start()
    {
        Destroy(gameObject, _destroyTime);
    }
}
