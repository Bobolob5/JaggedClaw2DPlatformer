using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    private void Update()
    {
        transform.Rotate(0,0,speed*360f*Time.deltaTime);
    }
}
