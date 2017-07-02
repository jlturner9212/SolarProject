using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : Planetoid {

	// Use this for initialization
	void Start () {
        Setup();
	}
	
	// Update is called once per frame
	void Update () {
        RevolveSpeed = 365f;
        Run();
	}
}
