using UnityEngine;

public class Base : MonoBehaviour
{
    // Oyuncu objesinin singleton değişkeni
    public static Base instance;

    void Awake()
    {
        // Singleton değişkenini ayarla
        instance = this;
    }
}
