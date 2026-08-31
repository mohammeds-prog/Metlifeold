using UiPath.CodedWorkflows;
using System;

namespace METLIFE
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public UiPath.GSuite.Activities.Api.DriveConnection My_Workspace_mohammeds_tusksupportpartners_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.DriveConnection Shared_mohammeds_tusksupportpartners_com__3 { get; set; }

        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_mohammeds_tusksupportpartners_com__2 = new UiPath.GSuite.Activities.Api.DriveConnection("ba0aaa90-88ea-4266-bf17-b3d49afb2900", resolver);
            Shared_mohammeds_tusksupportpartners_com__3 = new UiPath.GSuite.Activities.Api.DriveConnection("a23f1a4b-b2a9-4588-b231-90dbf3622f8e", resolver);
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_mohammeds_tusksupportpartners_com__2 { get; set; }
        public UiPath.GSuite.Activities.Api.GmailConnection Shared_mohammeds_tusksupportpartners_com__3 { get; set; }
        public UiPath.GSuite.Activities.Api.GmailConnection Shared_mohammeds_tusksupportpartners_com__4 { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_mohammeds_tusksupportpartners_com__2 = new UiPath.GSuite.Activities.Api.GmailConnection("1c061e5f-8693-49ee-8dd6-8aa84c36477d", resolver);
            Shared_mohammeds_tusksupportpartners_com__3 = new UiPath.GSuite.Activities.Api.GmailConnection("de24cadc-cbaa-448f-a95f-aa8f44cb80ce", resolver);
            Shared_mohammeds_tusksupportpartners_com__4 = new UiPath.GSuite.Activities.Api.GmailConnection("17eceb2a-9f77-42f3-bfce-800507d98bd3", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public UiPath.GSuite.Activities.Api.SheetsConnection My_Workspace_mohammeds_tusksupportpartners_com__2 { get; set; }

        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_mohammeds_tusksupportpartners_com__2 = new UiPath.GSuite.Activities.Api.SheetsConnection("17c283c4-6a5f-4fbd-95b8-eb2b84fa94d9", resolver);
        }
    }
}