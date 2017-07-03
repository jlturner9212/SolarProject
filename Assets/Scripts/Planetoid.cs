using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetoid : MonoBehaviour {


    public GameObject Sun;
    public GameObject Planet;
    public GameObject Moon;             // TODO: support array of moons
    public float Scale = 1f;

    public float PlanetSize = 1f;
    public Vector3 PlanetStartingPoint;

    public float RotationSpeed = 1f;
    public bool RotationDirection = true;   // TODO: check for rotation vector

    public float RevolveSpeed = 1f;
    public bool RevolveDirection = true;    // TODO: check planetoid revolve


    public float Gravity = 1f;



    protected void Setup()
    {
		Sun = GameObject.FindWithTag("Sun");
        Planet = GameObject.Find("Planet");
    }

    protected void Run()
    {
		if (RotationDirection)
		{
			transform.RotateAround(Sun.transform.position, Vector3.up, RotationSpeed * Time.deltaTime);
		}
		else { }
		if (RevolveDirection)
		{
            Planet.transform.Rotate(Vector3.up * RevolveSpeed * Time.deltaTime);
		}
		else { }
    }
}
