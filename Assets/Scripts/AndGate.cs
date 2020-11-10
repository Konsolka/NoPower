using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndGate : MonoBehaviour
{
	public GameObject [] wireLinesIn;
	public GameObject [] wireLineOut;
	public Material [] material;
	public GameMechanics mechanics;
	Renderer rend;
	private void Start()
	{
		rend = gameObject.transform.GetChild(2).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
		setToTag("Off");
	}
	private void Update()
	{
		if (getWireLineStates())
		{
			rend.sharedMaterial = material[1];
			setToTag("On");
		}
		else
		{
			rend.sharedMaterial = material[0];
			setToTag("Off");
		}
	}
	private bool getWireLineStates()
	{
		for (int i = 0; i < wireLinesIn.Length; i++)
		{
			if (wireLinesIn[i].tag == "Off")
			return (false);
		}
		return (true);
	}
	private void setToTag(string tag)
	{
		for (int i = 0; i < wireLineOut.Length; i++)
			wireLineOut[i].tag = tag;
	}
}
