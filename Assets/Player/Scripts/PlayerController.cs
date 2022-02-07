using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConteoller : Monobehaviour
{
	public GameObject playerGO;

	private Rigidbody weapon;



	void Start()
	{
		weapon = playerGO.GetComponent<Weapon>();
		// check that the default weapon is registered.
		if ( weapon == null )
		{
			// Oops! Weapon not registered and this is very bad!!!
			// register it!
			playerGO.AddCo
		}
		
	}
}