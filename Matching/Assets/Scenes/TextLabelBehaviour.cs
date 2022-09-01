using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public FloatData1 dataOBJ;

    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
        throw new NotImplementedException();
    }

    public void UpdateLabel()
    {
        label.text = dataOBJ.value.ToString(CultureInfo.InvariantCulture);
        throw new NotImplementedException();
    }
}
