using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	// Beschleunigung in x-, y- und z-Richtung
	public float accelerationX;
	public float accelerationY;
	public float accelerationZ;

	// Geschwindigkeit in x-, y- und z-Richtung
	private float velocityX = 0;
	private float velocityY = 0;
	private float velocityZ = 0;

	// Update is called once per frame
	void FixedUpdate()
	{
		float speedDiffX = accelerationX * Time.deltaTime;
		velocityX = velocityX + speedDiffX;

		// Bewegung = Zeitdifferenz * Geschwindigkeit
		// s = v * t
		float deltaX = velocityX * Time.deltaTime;
		float deltaY = velocityY * Time.deltaTime;
		float deltaZ = velocityZ * Time.deltaTime;

		// Translate = Bewege um ...
		this.transform.Translate(deltaX, deltaY, deltaZ);
	}
}

