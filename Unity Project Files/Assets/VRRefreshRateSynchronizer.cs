using UnityEngine;
using System.Collections;

public class VRRefreshRateSynchronizer : MonoBehaviour
{
    [Header("Target Configuration")]
    [SerializeField, Tooltip("Frecuencia objetivo para el Quest 3 (72, 80, 90, 120)")]
    private float _targetDisplayFrequency = 90.0f;

    private void Start()
    {
        StartCoroutine(SetRefreshRateRoutine());
    }

    private IEnumerator SetRefreshRateRoutine()
    {
        // Esperamos a que el OVRManager inicialice correctamente el hardware
        yield return new WaitUntil(() => OVRManager.display != null);

        // 1. Le ordenamos al hardware del Quest que intente usar nuestra frecuencia
        OVRManager.display.displayFrequency = _targetDisplayFrequency;

        // 2. Leemos la frecuencia REAL que el Quest aceptó (por si limitó los Hz por batería)
        float activeFrequency = OVRManager.display.displayFrequency;

        // 3. Sincronizamos las físicas de Unity matemáticamente
        if (activeFrequency > 0f)
        {
            Time.fixedDeltaTime = 1.0f / activeFrequency;
            Debug.Log($"[VR Sync] Hardware ejecutándose a {activeFrequency}Hz. Físicas sincronizadas a {Time.fixedDeltaTime}s.");
        }
    }
}
