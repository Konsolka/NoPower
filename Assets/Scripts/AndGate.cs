using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndGate : MonoBehaviour
{
	public matReturn material;
	public GameMechanics mechanics;
	public GameObject [] wireLinesIn;
	public GameObject [] wireLineOut;
	Renderer rend;
	private bool state;
	private void Start()
	{
		rend = gameObject.transform.GetChild(1).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material.retMatOff();
	}
	private void Update()
	{
		state = mechanics.getWireLineStatesAndGate(wireLinesIn);
		if (state)
		{
			rend.sharedMaterial = material.retMatOn();
			mechanics.changeTag(wireLineOut, "On");
		}
		else
		{
			rend.sharedMaterial = material.retMatOff();
			mechanics.changeTag(wireLineOut, "Off");
		}
	}
}
