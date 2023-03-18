// See https://aka.ms/new-console-template for more information
using Ex.Decorator.WebClientApp;
using System.Net;

var clientDecorator = new WebClientDecorator(new WebClient());

var source = clientDecorator.DownloadString("https://www.google.com");
