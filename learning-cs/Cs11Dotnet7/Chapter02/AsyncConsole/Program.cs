HttpClient client = new HttpClient();

HttpResponseMessage response = await client.GetAsync("https://apple.com");
WriteLine("Apple home page has {0:N0} bytes", response.Content.Headers.ContentLength);