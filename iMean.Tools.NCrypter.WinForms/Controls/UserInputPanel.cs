using DevExpress.XtraEditors;
using iMean.Tools.NCrypter.Business;

namespace iMean.Tools.NCrypter.WinForms.Controls
{
    public partial class UserInputPanel : XtraUserControl
    {
        private readonly INCryptR _nCryptR;
        private readonly IKeyFileManager _keyFileManager;

        public UserInputPanel()
        {
            InitializeComponent();
        }

        public UserInputPanel(INCryptR nCryptR, IKeyFileManager keyFileManager)
            : base()
        {
            _nCryptR = nCryptR ?? throw new ArgumentNullException(nameof(nCryptR));
            _keyFileManager = keyFileManager ?? throw new ArgumentNullException(nameof(keyFileManager));
        }

        protected override void OnFirstLoad()
        {
            base.OnFirstLoad();
        }

        private void OnKeyFilepathButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
        }
    }
}
