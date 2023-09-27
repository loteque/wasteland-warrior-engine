namespace Godot.Bridge;

public static class AlcReloadCfg
{
    private static bool _configured = false;

    public static void Configure(bool alcReloadEnabled)
    {
        if (_configured)
            return;

        _configured = true;

        IsAlcReloadingEnabled = alcReloadEnabled;
    }

    internal static bool IsAlcReloadingEnabled = false;
}
