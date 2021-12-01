using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player")]
public class PlayerData : ScriptableObject
{
    [SerializeField] protected int life;
}
