using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset;
    public GameObject player;

    void Start()
    {
        offset = player.transform.position - this.transform.position;
    }

    void Update()
    {
        this.transform.position = player.transform.position - offset;
    }
}
