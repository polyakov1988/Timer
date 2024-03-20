using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text _textMashPro;

    private int _value;
    
    private void Start()
    {
        _value = 0;
        _textMashPro.text = _value.ToString();
    }

    public void Increase()
    {
        _value++;
        _textMashPro.text = _value.ToString();
    }
}
