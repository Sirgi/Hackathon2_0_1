using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSwitcher : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Sprite _zombieSprite;
    [SerializeField] private Sprite _ghostSprite;
    private Transform _transform;
    private bool _isGhost=false;
    private bool IsGhost 
    {
        get
        {
            return _isGhost;
        }
        set
        {
            _isGhost=value;
            if(_isGhost)
            {
                gameObject.layer=6;
                _spriteRenderer.sprite=_ghostSprite;
                _spriteRenderer.color=new Color(1f,1f,1f,0.5f);
                StartCoroutine(GhostState());
            }
            else
            {   
                gameObject.layer=0;
                _spriteRenderer.sprite=_zombieSprite;
                _spriteRenderer.color=new Color(1f,1f,1f,1);
            }
        }
    }

    private void Awake()
    {
        _transform=GetComponent<Transform>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            IsGhost=!IsGhost;
        }
    }

    private IEnumerator GhostState()
    {
        while(IsGhost)
        {
            GhostPower.Value-=0.1f;
            if(GhostPower.Value==0f)
            {
                IsGhost=false;
            }
            yield return new WaitForSeconds(0.1f);
        }
    }
}
