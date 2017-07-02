using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    public Color32 Color;
    public Vector3 Scale = new Vector3( 1,1,1);


	// Use this for initialization
	void Start () {
        transform.localScale += (Scale);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
