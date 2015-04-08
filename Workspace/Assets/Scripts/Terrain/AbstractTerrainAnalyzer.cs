﻿using UnityEngine;
using System.Collections;

public abstract class AbstractTerrainAnalyzer : MonoBehaviour 
{
	public Transform[,] level; // insert board before doing anything
	public float maxTerrainHeat; // must be > 0
	public int ChokePointSize = 2;

	// goes through the level and analyzes it (adds in the basic heat values) while ignoring units
	public abstract void AnalyzeTerrain();
	public abstract Transform[][] GetChokePoints();
}
