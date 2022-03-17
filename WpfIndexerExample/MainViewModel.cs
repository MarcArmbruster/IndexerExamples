namespace WpfIndexerExample
{
    public class MainViewModel : WpfCommandAggregator.Core.BaseVm
    {
        public Translations MyTranslations { get; } = new Translations();
        
        protected override void InitCommands()
        {
            this.CmdAgg.AddOrSetCommand("Apply", p1 => this.ApplyChangesToUi(), p2 => true);
        }

        private void ApplyChangesToUi()
        {
            this.NotifyPropertyChanged(nameof(this.MyTranslations));
        }

        public MainViewModel()
        {
            this.MyTranslations["lblProduct"] = "Product";
            this.MyTranslations["lblPrice"] = "Price";
            this.NotifyPropertyChanged(nameof(this.MyTranslations));
        }
    }
}
