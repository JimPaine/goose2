#pragma checksum "C:\src\goose2s\State\SpotifyStateProvider.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461e2de1fd5a7418a5eea191bdff7449779407c3"
// <auto-generated/>
#pragma warning disable 1591
namespace goose2s.State
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\goose2s\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\goose2s\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\goose2s\_Imports.razor"
using goose2s;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\goose2s\_Imports.razor"
using goose2s.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\goose2s\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\src\goose2s\State\SpotifyStateProvider.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\goose2s\State\SpotifyStateProvider.razor"
using goose2s.Models;

#line default
#line hidden
#nullable disable
    public partial class SpotifyStateProvider : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\src\goose2s\State\SpotifyStateProvider.razor"
 if (_hasLoaded)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __Blazor.goose2s.State.SpotifyStateProvider.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 8 "C:\src\goose2s\State\SpotifyStateProvider.razor"
                            this

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddContent(5, 
#nullable restore
#line 9 "C:\src\goose2s\State\SpotifyStateProvider.razor"
         ChildContent

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 11 "C:\src\goose2s\State\SpotifyStateProvider.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.AddMarkupContent(9, "<p>Loading...</p>\r\n");
#nullable restore
#line 15 "C:\src\goose2s\State\SpotifyStateProvider.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\src\goose2s\State\SpotifyStateProvider.razor"
       
    private bool _hasLoaded;

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public SpotifyAuthResponse CurrentContext { get; set; }

    public SpotifyStateProvider()
    {
        this._sequenceNumber = DateTime.UtcNow.Ticks;
    }
    protected override async Task OnInitializedAsync()
    {
        CurrentContext = await ProtectedSessionStore.GetAsync<SpotifyAuthResponse>("auth");
        _hasLoaded = true;
    }

    public async Task SaveChangesAsync()
    {
        await ProtectedSessionStore.SetAsync("auth", CurrentContext);
    }

    public static QueueItem[] QueueMem = new QueueItem[0];
    public QueueItem[] _queue { get => QueueMem; set => QueueMem = value;}
    private long _sequenceNumber = 0L;


    public void Enqueue(string flock, SpotifyItem track)
    {
        try 
        {

        var entity = new QueueItem(flock, DateTime.UtcNow)
        {
            ArtistName = string.Join(", ", track.artists.Select(a => a.name)),
            DurationMs = track.duration_ms,
            Image = track.album.images.OrderBy(i => i.height).First().url,
            Popularity = track.popularity,
            TrackId = track.id,
            TrackName = track.name,
            Votes = 0
        };

        var q = new List<QueueItem>(_queue);
        q.Add(entity);
        this._queue = q.ToArray();
        _sequenceNumber = DateTime.UtcNow.Ticks;
        
        this.StateHasChanged();
        }
        catch (Exception ex) 
        {

        }
    }

    public async Task<(long, QueueItem[])> GetQueue(string flock, long sequenceNumber)
    {
        if (_sequenceNumber == sequenceNumber)
            return (long.MinValue, null);

        return (_sequenceNumber, _queue
            .Where(qi => qi.PartitionKey == flock && string.Compare(qi.RowKey, DateTime.UtcNow.Ticks.ToString()) > 0
                        && qi.PlayConcluded == 0L)
            .ToArray());

    }

    public async Task<(long, QueueItem)> GetFirst(string flock, long sequenceNumber)
    {
        if (_sequenceNumber == sequenceNumber)
            return (long.MinValue, null);

        return (_sequenceNumber, _queue
            .Where(qi => qi.PartitionKey == flock
                            && string.Compare(qi.RowKey, DateTime.UtcNow.Ticks.ToString()) > 0
                            && (qi.PlayConcluded == 0L || qi.PlayConcluded > DateTime.UtcNow.Ticks))
            .FirstOrDefault());

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
    }
}
namespace __Blazor.goose2s.State.SpotifyStateProvider
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
