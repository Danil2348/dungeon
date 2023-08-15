using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Collider axecollider;
    void Start()
    {
        Spawn();
    }
    private void FixedUpdate()
    {
        Run();
    }
    private void Run()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        { 
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isRunning", true);
        }
        else
            _animator.SetBool("isRunning", false);
    }
    public void ChangeLayerWeight(float newLayerWeight)
    {
        _animator.SetLayerWeight(1, newLayerWeight);
        if (newLayerWeight == 1)
        {
            axecollider.enabled = true;
        }
        else
        {
            axecollider.enabled = false;
        }
        
    }
    public void attack()
    {
        _animator.SetTrigger("Hit");
    }
    public void Spawn()
    {
        transform.position = new Vector3(0f,0f,-3f);
    }
}
