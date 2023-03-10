namespace BoldBI.Winforms
{
    internal class EmbedProperties
    {
        //Dashboard Server BI URL (ex: http://localhost:5000/bi/, http://demo.boldbi.com/bi/)
        public static string RootUrl = "http://localhost:5000/bi/";

        //For Bold BI Enterprise edition, it should be like `site/site1`. For Bold BI Cloud, it should be empty string
        public static string SiteIdentifier = "site/site1";

        //Your Bold BI application environment. (If Cloud, you should use `Cloud`, if Enterprise, you should use `OnPremise`)
        public static string Environment = "onpremise";

        //Your Embedding type. If you are embedding as component, you should set 'component', if your are embedding as ifrmae, you should set 'iframe'
        public static string EmbedType = "component";

        //Set the item id of the dashboard to embed from BI server, please refer this link(https://help.syncfusion.com/bold-bi/enterprise-bi/share-dashboards/get-dashboard-link#get-link)
        public static string DashboardId = "64fa25c8-341a-4421-b7b6-a61199b0bae3";

        //Enter your BoldBI credentials here.
        public static string UserEmail = "User Email here";

        // Get the embedSecret key from Bold BI.
        public static string EmbedSecret = "Embed secret key here";
    }
}