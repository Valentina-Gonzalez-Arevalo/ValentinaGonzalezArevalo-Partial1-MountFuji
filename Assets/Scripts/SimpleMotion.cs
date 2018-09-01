using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMotion : MonoBehaviour {

    public float translationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(translationSpeed, 0, 0);
		
	}
}
