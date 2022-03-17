using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeIcon : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private Image _foreground;
    [SerializeField] private Text _text;

    public void Begin()
    {
        _background.color = new Color(1, 1, 1, 0.4f);
        _foreground.enabled = true;
        _text.enabled = true;
    }
    public void SetValue(float currentCharge, float maxCharge)
    {
        _foreground.fillAmount = currentCharge / maxCharge;
        _text.text = Mathf.Ceil(maxCharge - currentCharge).ToString();
    }

    public void Stop()
    {
        _background.color = new Color(1, 1, 1, 1);
        _foreground.enabled = false;
        _text.enabled = false;
    }

}