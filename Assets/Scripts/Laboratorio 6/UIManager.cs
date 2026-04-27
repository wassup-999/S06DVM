using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [FoldoutGroup("References")]
    public Image HealthBar;
    [FoldoutGroup("References")]
    public TextMeshProUGUI LifePorcentage;
    
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
        HealthBar.fillAmount = GameManager.Instance.Player.Life / GameManager.Instance.Player.MaxLife;
        LifePorcentage.text = GameManager.Instance.Player.Life.ToString() + "%";
    }
}
