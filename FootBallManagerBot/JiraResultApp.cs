//using Atlassian;
//using Atlassian.Jira;
//using System.Collections;

//namespace JiraResultsApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Jira jiraConn = new Jira("http://yourjiraurl.com/", jUserID, jPassword);
//            //string jqlString = PrepareJqlbyDates("2014-03-01", "2014-03-31");
//            //IEnumerable < Atlassian.Jira.Issue >< atlassian.jira.issue >
//            //    jiraIssues = jiraConn.GetIssuesFromJql(jqlString, 999);

//            //foreach (var issue in jiraIssues)
//            //{
//            //    System.Console.WriteLine(issue.Key.Value + " -- " + issue.summary);
//            //}
//        }

//        static string PrepareJqlbyDates(string beginDate, string endDate)
//        {
//            string jqlString = "project = PRJ AND status = Closed AND 
//            resolved >= "+beginDate+" AND resolved <= "+ endDate;
//            return jqlString;
//        }
//    }
//}