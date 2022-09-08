using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
	public int initValue;
	public int value;

	private void OnEnable()
	{
		value = initValue;
	}
}
