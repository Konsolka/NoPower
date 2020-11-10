using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WireStateChange : MonoBehaviour
{
	public matReturn materials;
	public GameMechanics mechanics;
	private bool _state;
	Renderer rend;
	private void Start()
	{
		mechanics.changeWireLine(gameObject, materials.retMatOff());
	}
	private void Update()
	{
		if (gameObject.tag == "Off")
			mechanics.changeWireLine(gameObject, materials.retMatOff());
		else
			mechanics.changeWireLine(gameObject, materials.retMatOn());
	}

}
