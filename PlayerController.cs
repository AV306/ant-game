using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Monobehaviour
{
	public GameObject playerGO;

	private Weapon weapon;



	void Start()
	{
		weapon = playerGO.GetComponent<Weapon>();

		/*
		 * Failsafes.
		 */

		// check that the default weapon is registered.
		if ( weapon == null )
		{
			// Oops! Weapon not registered and this is very bad!!!
			// register it!
			playerGO.AddComponent( Weapon );
		}

		if ( weapon.type != weapon.HAND )
		{
			// starting on wrong weapon type :O
			weapon.type = weapon.HAND;
		}
	}

	void Update()
	{
		// method 1. use mouseDelta and raycast

		// Y is up, so change the Vector3 attributes.
		Vector3 targetPos = new Vector3( Input.mousePosition.x, 0, Input.mousePosition.y );

		// now for the stupid part. Convert the coordinate scale.
	
		if ( Input.GetMouseButtonDown( 0 ) )
		{
			// if the user clicks,
			// use weapon.
			weapon.Use( targetPos );
		}
	}
}