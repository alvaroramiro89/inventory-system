using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Stats/Player Stats", order = 1)]
public class PlayerStats : ScriptableObject
{
    public int health;
    public int armour;
    public int stamina;
    public int fashion;

    // Método para reiniciar los stats a cero
    public void ResetStats()
    {
        health = 0;
        armour = 0;
        stamina = 0;
        fashion = 0;
    }

    // Método para agregar stats de un item
    /*public void AddStats(ItemStats itemStats)
    {
        health += itemStats.health;
        armour += itemStats.armour;
        stamina += itemStats.stamina;
        fashion += itemStats.fashion;
    }*/
}
