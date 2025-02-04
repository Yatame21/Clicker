using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public static int money;
    public static int click = 1;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money", 0);
    }
    public void Click()
    {
        money += click;
        PlayerPrefs.SetInt("money", money);
    }

    public void Update()
    {
        moneyText.text = "$" + money;
    }
}
