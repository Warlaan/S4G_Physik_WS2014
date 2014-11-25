using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	// Beschleunigung in x-, y- und z-Richtung
	public Vector3 acceleration;

	// Geschwindigkeit in x-, y- und z-Richtung
	private Vector3 velocity;

	// Wie stark das Objekt bei einer Kollision reflektiert wird.
	// 1 = elastischer Stoß, 0 = unelastischer Stoß
	public float bounciness = 0.9f;

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

	// wird bei einer Kollision aufgerufen
	void OnCollisionEnter(Collision collision)
	{
		OnCollisionWithWall(collision);
	}

	void OnCollisionWithWall(Collision collision)
	{
		// Setze neue Geschwindigkeit, die in x- und z-Richtung unverändert
		// ist und in y-Richtung reflektiert wurde.
		velocity = new Vector3(velocity.x, -velocity.y * bounciness, velocity.z);
	}
}

