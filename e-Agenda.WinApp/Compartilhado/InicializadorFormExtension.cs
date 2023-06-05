namespace e_Agenda.WinApp.Compartilhado
{
    public static class InicializadorFormExtension
    {
        public static void ConfigurarTelas(this Form form)
        {
            form.ShowIcon = false;
            form.ShowInTaskbar = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
        }
    }
}
