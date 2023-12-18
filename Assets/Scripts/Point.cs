using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject meteors;
    void Start()
    {
        Instantiate(meteors, transform.position, Quaternion.identity);
    }
}
