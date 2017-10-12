using UnityEngine;
using Zenject;

namespace ZenjectInstallers
{
    [CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "ZenjectInstallers/GameSettingsInstaller")]
    public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller>
    {
        public GameInstaller.Settings GameInstallerSettings;

        public override void InstallBindings()
        {
            Container.BindInstance(GameInstallerSettings);
        }
    }
}