using PagarmeCoreApi.PCL.Http.Request;
using PagarmeCoreApi.PCL.Http.Response;

namespace PagarmeCoreApi.PCL.Http.Client
{
    /// <summary>
    /// Delegate to handle the event on before http request. This event is raised before any
    /// network call is made, and can be used for logging, request modification, appending
    /// additional headers etc.
    /// </summary>
    /// <param name="source">The source HttpClient that is going to make the network call</param>
    /// <param name="request">The underlying HttpRequest being sent over the network</param>
    public delegate void OnBeforeHttpRequestEventHandler(IHttpClient source, HttpRequest request);

    /// <summary>
    /// Delegate to handle the event on after http response. This event is raised after any
    /// network response is recieved, and can be used for logging, response modification, extracting
    /// additional information etc.
    /// </summary>
    /// <param name="source">The source HttpClient that recieved the response from the network call</param>
    /// <param name="request">The underlying HttpResponse recieved from the network</param>
    public delegate void OnAfterHttpResponseEventHandler(IHttpClient source, HttpResponse response);
}
