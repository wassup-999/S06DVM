using System;
using Unity.Cinemachine;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [FoldoutGroup("References")]
    public ThirdPersonController PlayerController;
    [FoldoutGroup("References")]
    public PlayerMechanics Player;
    [FoldoutGroup("References")]
    public EnemySpawner enemySpawner;
    [FoldoutGroup("References")]
    public GameObject EnemyPrefab;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }    
}
