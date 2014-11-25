using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	// Beschleunigung in x-, y- und z-Richtung
	public Vector3 acceleration;

	// Geschwindigkeit in x-, y- und z-Richtung
	private Vector3 velocity;

	// Update is called once per frame
	void FixedUpdate()
	{
		// speedDiff ist die Änderung der Geschwindigkeit in diesem Frame
		Vector3 speedDiff = acceleration * Time.fixedDeltaTime;
		// die velocity (=Geschwindkeit) ändert sich um speedDiff
		velocity = velocity + speedDiff;

		// Bewegung = Geschwindigkeit * vergangene Zeit
		// s = v * t
		Vector3 posDiff = velocity * Time.fixedDeltaTime;

		// Translate = Bewege um ...
		this.transform.Translate(posDiff);
	}
}

