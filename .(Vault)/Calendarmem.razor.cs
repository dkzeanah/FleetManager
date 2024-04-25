using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using BlazorApp1;
using BlazorApp1.Pages;
using BlazorApp1.Pages.Components;
using BlazorApp1.Shared;
using System.Net.NetworkInformation;
using BlazorApp1.Services;
using BlazorApp1.Services.Interfaces;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.BlazorApp1;
using Microsoft.AspNetCore.Identity;
using Havit.Blazor.Components.Web;
using Havit.Blazor.Components.Web.Bootstrap;
using ClosedXML;
using Microsoft.JSInterop;
using BlazorApp1.Data;
using BlazorApp1.CarModels;
using Block = BlazorApp1.CarModels.Block;

namespace BlazorApp1.Pages
{
    public partial class Calendarmem
    {
        private List<string> Users { get; set; } = new List<string> { "User1", "User2", "User3" };
        private List<CarModels.Block> Blocks { get; set; } = new List<Block>();

        private DateTime SelectedDate { get; set; } = DateTime.Today;
        private string NoteContent { get; set; } = string.Empty;

        private const int DaysInWeek = 7;
        private int DaysInMonth => DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
        private int WeeksInMonth => (int)Math.Ceiling((DaysInMonth + FirstDayOfWeek) / (double)DaysInWeek);
        private int FirstDayOfWeek => (int)new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).DayOfWeek;

        public string Title { get;  set; }

        private void SelectDate(DateTime date)
        {
            SelectedDate = DateTime.Now;
        }

        // Rest of the code
        private async Task AddNote()
        {
            Db.Notes.Add(new Data.Note
            { Title = NoteContent, Content = NoteContent, CreatedAt = SelectedDate, AuthorId = "123", // Hardcoded AuthorId
                IsDeleted = false });
            StateHasChanged();
            await Db.SaveChangesAsync();
            //Nav.NavigateTo("/calendar", forceLoad: true);
        }
        //[Parameter]
        private void HandleAddedBlock(Block newBlock)
        {
            // Do something with the new block, for example, add it to a list:
            Blocks.Add(newBlock);

            // Or maybe you want to send it to a server, display a notification, etc. Adjust as per your needs.
        }
    }
}