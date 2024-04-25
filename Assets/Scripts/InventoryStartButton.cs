using UnityEngine;

public class InventoryStartButton : MonoBehaviour
{
    // Este método será llamado cuando se haga clic en el botón
    public void DisableGameObject()
    {
        // Desactivar el GameObject que contiene este script
        gameObject.SetActive(false);
    }
}
