using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomrotate : MonoBehaviour
{
    private int[] gradus = new int[] { 0, 90, 180, 270 };
    void Start()
    {
        transform.Rotate(0f, gradus[Random.Range(0, gradus.Length)], 0f);
    }
}
