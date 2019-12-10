using UnityEngine;

// Handles the saving and loading of PlayerPrefs
public class PlayerPrefsHandler
{
    public const string FOV_INT = "FOV";

    // Restore settings to what they were
    public void RestorePreferences()
    {
        SetFov(GetFOV());
    }

    public void SetFov(int fov)
    {
        // Set Field of view
        fov = Mathf.Clamp(fov, 90, 120);

        PlayerPrefs.SetFloat(FOV_INT, fov);
        Camera.main.fieldOfView = fov;
    }

    // Retrieves setting
    public int GetFOV()
    {
        return PlayerPrefs.GetInt(FOV_INT);
    }
}