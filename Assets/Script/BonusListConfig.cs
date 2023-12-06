using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "BonusListConfig", menuName = "Configs/BonusListConfig", order = 0)]
public class BonusListConfig : ScriptableObject
{
    [SerializeField] private List<Bonus> _bonuses;

    public List<Bonus> Bonuses => _bonuses;
}

[Serializable]
public class Bonus
{
    [SerializeField] private Image _bonusImage;
    [SerializeField] private int _bonusCount;

    public Image BonusImage => _bonusImage;
    public int BonusCount => _bonusCount;
}
