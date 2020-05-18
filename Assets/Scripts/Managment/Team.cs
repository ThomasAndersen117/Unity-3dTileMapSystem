using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Team", menuName = "ScriptableObjects/Player/New Team", order = 2)]
public class Team : ScriptableObject
{

    public List<Unit> team = new List<Unit>();

    public void Add(Unit t) { team.Add(t); }

    public void Remove(Unit t) { team.Remove(t); }

}