using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerController player;
    public AIVehicle enemyCar;

    void Start()
    {
        InitializeGame();
    }

    void InitializeGame() // High-level method
    {
        player.Speed = 30f;  // Uses encapsulation
        enemyCar.Speed = 25f;
    }
}
