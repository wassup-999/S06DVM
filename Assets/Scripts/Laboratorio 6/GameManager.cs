using System;
using Unity.Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [FoldoutGroup("References")]
    public ThirdPersonController Player;
    [FoldoutGroup("References")]
    public EnemySpawner enemySpawner;
    [FoldoutGroup("References")]
    public GameObject EnemyPrefab;
}
