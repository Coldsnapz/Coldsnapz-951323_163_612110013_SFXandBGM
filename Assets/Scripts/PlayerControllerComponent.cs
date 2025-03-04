﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerComponent : MonoBehaviour
{
    private Vector3 _controlAxes = Vector3.zero;

    const float MOVEMENT_SCALE_FACTOR = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _controlAxes = Vector3.zero;

        _controlAxes.x = Input.GetAxis("Horizontal") * MOVEMENT_SCALE_FACTOR;
        _controlAxes.z = Input.GetAxis("Vertical") * MOVEMENT_SCALE_FACTOR;

        if (Input.GetKey(KeyCode.R))
        {
            _controlAxes.y += MOVEMENT_SCALE_FACTOR * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F))
        {
            _controlAxes.y -= MOVEMENT_SCALE_FACTOR * Time.deltaTime;
        }

        if (this.GetComponent<Rigidbody>() != null)
        {
            this.GetComponent<Rigidbody>().transform.position += _controlAxes;
        }
        else
            this.transform.position += _controlAxes;
    }
}
