using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using System.Threading.Tasks;
using FootBall;
using Microsoft.Bot.Builder.Luis.Models;

namespace FootBallManagerBot
{

    [LuisModel("15d11fa0-6af4-46c5-b434-62065ac9015a", "8fa712b1511f4a7a8270f0366157d3bd")]
    [Serializable]
   

    public class SimpleLUISDialogs : LuisDialog<Object> 
    {
        [LuisIntent("Greeting")]
        public async Task GetGreeting(IDialogContext dialogContext,LuisResult result)
        {
            ChampionShips champs = new ChampionShips();
            await dialogContext.PostAsync("Hello , What can I do for you today");
            dialogContext.Wait(MessageReceived);

        }

        [LuisIntent("TeamCount")]
        public async Task GetTeamCount(IDialogContext dialogContext, LuisResult result)
        {
            ChampionShips champs = new ChampionShips();
            await dialogContext.PostAsync($"There are total { champs.GetTeamCount() } number of teams in the Championship.");
            dialogContext.Wait(MessageReceived);

        }
        [LuisIntent("")]
        public async Task None(IDialogContext dialogContext, LuisResult result)
        {
            await dialogContext.PostAsync("I Have no Idea What you are talking about.");
            dialogContext.Wait(MessageReceived);
        }


    }
}