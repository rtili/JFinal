using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IOnCollider
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private AudioSource _playerAudioSrc;
    [SerializeField] private AudioClip _walkSound;
    [SerializeField] private AudioClip _jumpSound;

    public bool OnCollider { set { _onCollider = value; } }
    private PlayerControl _pControl;
    private Rigidbody2D _rb;
    private bool _onCollider;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _pControl = new PlayerControl();
        _pControl.Enable();
    }

    private void Update()
    {
        Move();
        if (_onCollider)
            Jump();
    }

    private void Move()
    {
        Vector2 moveDirection = _pControl.Movement.Move.ReadValue<Vector2>();
        transform.Translate(moveDirection * _speed * Time.deltaTime);
        if (moveDirection.x < 0)
        {
            transform.localScale = new Vector2(-1,1);
            if (!_playerAudioSrc.isPlaying && _onCollider)
            {
                _playerAudioSrc.PlayOneShot(_walkSound);
            }            
        }        
        if (moveDirection.x > 0)
        {
            transform.localScale = new Vector2(1, 1);
            if (!_playerAudioSrc.isPlaying && _onCollider)
            {
                _playerAudioSrc.PlayOneShot(_walkSound);
            }
        }
    }

    private void Jump()
    {
        if (_pControl.Movement.Jump.triggered)
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _playerAudioSrc.PlayOneShot(_jumpSound);
        }       
    }
}
