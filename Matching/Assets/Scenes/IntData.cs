using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int hits;

    public void UpdateHits(int touches)
    {
        hits += touches;
    }
}
