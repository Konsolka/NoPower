using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGate : MonoBehaviour
{
	public GameObject [] wireLinesIn;
	public GameObject [] wireLineOut;
	public Material [] material;
	Renderer rend;
	private void Start()
	{
		rend = gameObject.transform.GetChild(1).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
	}
	private void Update()
	{
		if (getWireLineStates())
		{
			rend.sharedMaterial = material[1];
			for (int i = 0; i < wireLineOut.Length; i++)
				wireLineOut[i].tag = "On";
		}
		else
		{
			rend.sharedMaterial = material[0];
			for (int i = 0; i < wireLineOut.Length; i++)
				wireLineOut[i].tag = "Off";
		}
	}
	private bool getWireLineStates()
	{
		for (int i = 0; i < wireLinesIn.Length; i++)
		{
			if (wireLinesIn[i].tag == "On")
			return (true);
		}
		return (false);
	}
}
