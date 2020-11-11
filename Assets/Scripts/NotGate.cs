using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : MonoBehaviour
{
	public GameObject wireLineIn;
	public GameObject wireLineOut;
	public matReturn material;
	Renderer rend;
	private bool state;
	private void Start()
	{
		state = true;
		if (wireLineIn == null)
		{
			state = false;
			wireLineOut.tag = "On";
		}
		rend = gameObject.transform.GetChild(2).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material.retMatOn();
	}
	private void Update()
	{
		if (state)
		{
			if (wireLineIn.tag == "Off")
			{
				rend.sharedMaterial = material.retMatOn();
				wireLineOut.tag = "On";
			}
			else if (wireLineIn.tag == "On")
			{
				rend.sharedMaterial = material.retMatOff();
				wireLineOut.tag = "Off";
			}
		}
	}
}
