using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private GameObject _healthIconPrefab;
    [SerializeField] private List<GameObject> HealthIcons = new List<GameObject>();
    public void Setup(int health)
    {
        for (int i = 0; i < health; i++)
        {
          GameObject newIcon=  Instantiate(_healthIconPrefab, transform);
            HealthIcons.Add(newIcon);
        }
    }

    public void DisplayHealth(int currentHealth)
    {
        for (int i = 0; i < HealthIcons.Count; i++)
        {
            if(i<currentHealth)
            {
                HealthIcons[i].SetActive(true);
            }
            else
            {
                HealthIcons[i].SetActive(false);
            }
        }
    }
}
