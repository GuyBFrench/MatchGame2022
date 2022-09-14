using UnityEngine;

[CreateAssetMenu]
public class IntData1 : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}