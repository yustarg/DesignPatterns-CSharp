namespace DesignPatterns_CSharp.Behavioral.Chain_of_Responsibility
{
    public class CoRClient
    {
        public static void Run()
        {
            var dialog = new Dialog(/*"Budget Reports"*/);
            dialog.wikiPageURL = "http://...";
            var panel = new Panel( /*0, 0, 400, 800*/);
            panel.modalHelpText = "This panel does...";
            // ok = new Button(250, 760, 50, 20, "OK")
            // ok.tooltipText = "This is an OK button that..."
            // cancel = new Button(320, 760, 50, 20, "Cancel")
            // // ...
            // panel.add(ok)
            // panel.add(cancel)
            dialog.Add(panel);
            
            dialog.ShowHelp();
        }
    }
}