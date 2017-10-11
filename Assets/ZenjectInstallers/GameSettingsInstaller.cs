using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "ZenjectInstallers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
{
    public GameInstaller.Settings IocInstallerSettings;

    public override void InstallBindings()
    {
        Container.BindInstance(IocInstallerSettings);
    }
}