using UnityEngine;
using TMPro;

public class PickupManager : MonoBehaviour
{
    public static PickupManager instance;

    private int coins;
    [SerializeField] private TMP_Text nummberText;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    void OnGUI()
    {
        nummberText.text = coins.ToString();
    }

    public void ChangeNumber(int amount)
    {
        coins += amount;
    }
}
