using UnityEngine;

[CreateAssetMenu]
public class Vector3Data1 : ScriptableObject
{
    public Vector3 position;

    public void PrintPosition(string current)
    {
        current = position.ToString();
        PrintPosition(current);
    }
}