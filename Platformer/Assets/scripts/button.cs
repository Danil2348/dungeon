using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] private Playercontroller player;
    public void a()
    {
        player.attack();
    }
}
