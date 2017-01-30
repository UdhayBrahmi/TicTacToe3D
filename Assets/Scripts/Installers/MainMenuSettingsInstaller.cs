using Zenject;

namespace TicTacToe3D
{
    public class MainMenuSettingsInstaller : ScriptableObjectInstaller<MainMenuSettingsInstaller>
    {
        public AdvancedSettingsPresenter.Settings AdvancedSettingsPresenterSettings;
        public NewGameMenuPresenter.Settings NewGameMenuSettings;
        public PlayerRowModel.Settings PlayerRowSettings;
        public MainMenuInstaller.Settings MainMenuInstallerSettings;

        public override void InstallBindings()
        {
            Container.BindInstance(AdvancedSettingsPresenterSettings);
            Container.BindInstance(NewGameMenuSettings);
            Container.BindInstance(PlayerRowSettings);
            Container.BindInstance(MainMenuInstallerSettings);
        }
    }
}