using UnityEngine;

public class matReturn : MonoBehaviour
{
	public Material [] materials;

	public Material retMatOff()
	{
		return (materials[0]);
	}

	public Material retMatOn()
	{
		return (materials[1]);
	}
}
