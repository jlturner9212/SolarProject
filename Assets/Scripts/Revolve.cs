using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolve : MonoBehaviour {

    public float RevolveSpeed = 1f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		Spin();
	}

    public void Spin()
	{
		if (true)
		{
			transform.Rotate(Vector3.up * RevolveSpeed * Time.deltaTime);
		}
		else { }
	}

}
