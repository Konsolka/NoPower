using UnityEngine;

public class FinishChange : MonoBehaviour
{
	public GameManager gameManger;
	public GameMechanics mechanics;
	private bool _status;
	public GameObject [] wireLines;
	private Renderer _rend;
	private void Start()
	{
		_rend = gameObject.transform.GetChild(1).GetComponent<Renderer>();
		_rend.sharedMaterial.SetColor("Color_12C89509", Color.red);
		_rend.enabled = true;
		_status = false;
	}
	private void Update()
	{
		if (!_status)
		{
			if (mechanics.getWireLineStatesAndGate(wireLines))
			{
				_status = true;
				_rend.sharedMaterial.SetColor("Color_12C89509", Color.green);
				gameManger.CompleteLevel();
			}

		}
	}
}
