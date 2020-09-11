﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BuildingType")]
public class BuildingTypeScriptableObject : ScriptableObject {
    public string nameString;
    public Transform prefab;
    public Sprite sprite;
    public ResourceGeneratorData resourceGeneratorData;
    public float minSeparation;
    public ResourceAmount[] productionCosts;
}
