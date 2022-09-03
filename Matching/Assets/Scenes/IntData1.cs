using UnityEngine;

[CreateAssetMenu]
public class IntData1 : ScriptableObject
{
    public int hits;

    public void UpdateHits(int touches)
    {
        hits += touches;
    }
}