using MetroRadiance.UI;
using System.Windows;

namespace MetroTester
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Window Close時にシステムを終了する。
            base.OnStartup(e);
            ShutdownMode = ShutdownMode.OnMainWindowClose;

            // テーマサービスの登録を行う。
            ThemeService.Current.Register(this, Theme.Windows, Accent.Windows);
        }
    }
}
