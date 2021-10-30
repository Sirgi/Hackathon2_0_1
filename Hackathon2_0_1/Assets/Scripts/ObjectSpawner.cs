using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [System.Serializable] public class SpawnObject
    {
        [SerializeField] private GameObject _value;
        [SerializeField] private Vector2 _offset;

        public GameObject Value { get => _value;}
        public Vector2 Offset { get => _offset;}
    }
    [System.Serializable] public class SpawnSet
    {
        [SerializeField] private SpawnObject[] _value;

        public SpawnObject[] Value { get => _value; set => _value = value; }
    }

    private Vector2 _position;
    [SerializeField] private SpawnSet[] _spawnSet;
    [SerializeField] private float _spawnRate=1f;

    private void Awake()
    {
        if(_spawnSet.Length==0)
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        _position=GetComponent<Transform>().position;
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        int randomIndex=0;
        while(true)
        {
            randomIndex=Random.Range(0,_spawnSet.Length);
            for(int i=0;i<_spawnSet[randomIndex].Value.Length;i++)
            {
                Instantiate(_spawnSet[randomIndex].Value[i].Value,_position+_spawnSet[randomIndex].Value[i].Offset,Quaternion.identity);
            }
            yield return new WaitForSeconds(_spawnRate);
        }
    }
}
