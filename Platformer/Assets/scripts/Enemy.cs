using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Collider swordcollider;
    [SerializeField] private Transform playerpos;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Run();
    }
    private void Run()
    {
        if (Mathf.Abs(Vector3.Distance(playerpos.position, transform.position)) < 0.3f)
        {
            _animator.SetTrigger("Hit");
        }
        if (Mathf.Abs(Vector3.Distance(playerpos.position, transform.position)) < 5f && Mathf.Abs(Vector3.Distance(playerpos.position, transform.position)) > 0.3f)
        {
            agent.destination = playerpos.position;
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
            swordcollider.enabled = true;
        }
        else
        {
            swordcollider.enabled = false;
        }

    }
}
