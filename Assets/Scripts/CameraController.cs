using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Ball;
    private Vector3 offset;

	// Use this for initialization
	void Start () {

        offset = transform.position - Ball.transform.position;
		
	}
	
	// Update is called once per frame
	void LateUpdate () {

        transform.position = Ball.transform.position + offset;
	}
}
