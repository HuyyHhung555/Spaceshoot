using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject destructionFX;

    // 👇 thêm biến GameOver UI
    public GameObject gameOverUI;

    public static Player instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // method for damage processing
    public void GetDamage(int damage)
    {
        Destruction();
    }

    // Player destruction procedure
    void Destruction()
    {
        // tạo hiệu ứng nổ
        Instantiate(destructionFX, transform.position, Quaternion.identity);

        // 👇 hiện Game Over
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        // 👇 dừng game
        Time.timeScale = 0f;

        // xoá player
        Destroy(gameObject);
    }
}