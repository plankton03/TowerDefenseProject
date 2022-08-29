using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower",menuName = "Create object of tower class")]
public class Tower : ScriptableObject
{
    public string towerName;

    [Multiline]
    public string towerDescription;

    public Transform towerPrefab;



}
