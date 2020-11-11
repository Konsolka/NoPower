using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGate : MonoBehaviour
{
	public GameMechanics mechanics;
	public matReturn material;
	public GameObject [] wireLinesIn;
	public GameObject [] wireLineOut;
	Renderer rend;
	private bool state;
	private void Start()
	{
		state = false;
		rend = gameObject.transform.GetChild(1).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material.retMatOff();
	}
	private void Update()
	{
		state = mechanics.getWireLineStatesOrGate(wireLinesIn);
		if (state)
		{
			rend.sharedMaterial = material.retMatOn();
			mechanics.changeTag(wireLineOut, "On");
		}
		else if (!state)
		{
			rend.sharedMaterial = material.retMatOff();
			mechanics.changeTag(wireLineOut, "Off");
		}
	}

}
