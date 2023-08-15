using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] private Transform Player;
    void LateUpdate()
    {
        transform.position = Player.position;
        transform.rotation = Player.transform.rotation;
    }
}
