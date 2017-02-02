using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Atlassian;
using Atlassian.Jira;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Dialogs;
using System.Threading.Tasks;
using FootBall;

namespace FootBallManagerBot
{

    [Serializable]
    public class SimpeDialogs : IDialog
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(ActivityRecievedAsync);
        }

        private async Task ActivityRecievedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            ChampionShips champ = new ChampionShips();
            activity.Text.ToLower();


            //var actvity = await result as Activity;
            //// create a connection to JIRA using the Rest client
            //var jira = Jira.CreateRestClient("https://vaticahealth.atlassian.net/", "shanky", "shanky@123");

            //// use LINQ syntax to retrieve issues
            //var issues = from i in jira.Issues.Queryable
            //             where i.Assignee == "sbahuguna"
            //             orderby i.Created
            //             select i;

            //await context.PostAsync("hello"); // issues
            //context.Wait(GetTasks);


            if (activity.Text.Contains("who") || activity.Text.Contains("which team"))
            {
                if (activity.Text.Contains("best") || activity.Text.Contains("great") || activity.Text.Contains("top") || activity.Text.Contains("won"))
                {
                    await context.PostAsync("This team " + champ.GetBestTeam());
                }

                else if (activity.Text.Contains("worst") || activity.Text.Contains("suck") || activity.Text.Contains("last") || activity.Text.Contains("lost"))
                {
                    await context.PostAsync("This team " + champ.GetLastTeam());
                }
            }
            else if (activity.Text.Contains("team"))
            {
                if (activity.Text.Contains("total") || activity.Text.Contains("count"))
                {
                    await context.PostAsync("There are " + champ.GetTeamCount() + " ");
                }
                else
                {
                    await context.PostAsync(" there are the teams " + string.Join(", ", champ.GetTeams()));
                }
            }
            else
            {
                await context.PostAsync("I only take limited response");
            }

            context.Wait(ActivityRecievedAsync);
        }
    }
}