using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [FoldoutGroup("References")]
    public Image HealthBar;
    public TextMeshPro LifePorcentage;
    void Start()
    {
        
    }

    
    void Update()
    {
        UpdateDamage();
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UpdateDamage()
    {
        GameManager.Instance.Enemy.MakeDamage();
    }
}
