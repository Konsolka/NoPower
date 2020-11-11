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
		state = false;
		rend = gameObject.transform.GetChild(2).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material.retMatOn();
	}
	private void Update()
	{
		state = wireLineIn.tag == "Off" ? true : false;
		if (state)
		{
			rend.sharedMaterial = material.retMatOn();
			wireLineOut.tag = "On";
		}
		else if (!state)
		{
			rend.sharedMaterial = material.retMatOff();
			wireLineOut.tag = "Off";
		}
	}
}
