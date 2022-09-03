using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 RotateVector;


    void Update()
    {
        transform.Rotate(RotateVector * Time.deltaTime);
    }
}
