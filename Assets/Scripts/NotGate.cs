using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : MonoBehaviour
{
	public GameObject wireLinesIn;
	public GameObject wireLineOut;
	public Material [] material;
	Renderer rend;
	private void Start()
	{
		rend = gameObject.transform.GetChild(2).GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[1];
	}
	private void Update()
	{
		if (wireLinesIn.tag == "Off")
		{
			rend.sharedMaterial = material[1];
			wireLineOut.tag = "On";
		}
		else
		{
			rend.sharedMaterial = material[0];
			wireLineOut.tag = "Off";
		}
	}
}
