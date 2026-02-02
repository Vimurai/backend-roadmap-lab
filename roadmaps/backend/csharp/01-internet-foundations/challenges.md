# ⚔️ Challenges: Speaking HTTP

## Easy: The Inspector
1.  Open Chrome/Edge. Press F12.
2.  Go to **Network** tab.
3.  Visit `https://httpbin.org/get`.
4.  Find the request in the list.
5.  **Challenge:** Identify the "User-Agent" header. What does it say about your computer?

## Easy: The Pinger
1.  Open Terminal.
2.  Run `ping google.com`.
3.  **Challenge:** Write down the IP address it reveals. That's Google's front door.

## Easy: The Lookup
1.  Open Terminal.
2.  Run `nslookup github.com`.
3.  **Challenge:** How many IP addresses did it return? Why might there be more than one?

## Medium: The Curl User
`curl` is a command-line browser without a screen.
1.  Run `curl https://httpbin.org/get`.
2.  Run `curl -I https://httpbin.org/get`. (This shows only Headers).
3.  **Challenge:** What Server software is httpbin using? (Look at the `Server` header).

## Medium: The Poster
1.  We want to *send* data, not just get it.
2.  Run `curl -X POST https://httpbin.org/post`.
3.  **Challenge:** Now send data with it: `curl -X POST -d "name=Bond" https://httpbin.org/post`. Check the JSON response to see if it received your name.

## Medium: The Faker
1.  Modify your "User-Agent" to look like an iPhone.
2.  `curl -A "Mozilla/5.0 (iPhone; CPU iPhone OS 14_0 like Mac OS X)" https://httpbin.org/user-agent`.
3.  **Challenge:** Verify the server thinks you are an iPhone.

## Hard: The Raw Talk
1.  Use `telnet` or `nc` (netcat) to manually type HTTP.
2.  Connect: `nc google.com 80`.
3.  Type precisely:
    ```
    GET / HTTP/1.1
    Host: google.com

    ```
    (Hit Enter twice).
4.  **Challenge:** Did you get a 200 OK or a 301 Moved Permanently? Read the raw text.

## Hard: The Header Hacking
1.  Send a custom header `X-Secret-Password: 123` to `https://httpbin.org/headers`.
2.  Verify it comes back in the response.

## Boss Challenge: "The Man in the Middle" 🕵️
**Goal:** Intercept traffic.
1.  Download **Postman** (or stay with curl if you prefer).
2.  Make a request to `https://jsonplaceholder.typicode.com/posts/1`.
3.  **Task:**
    - Read the JSON.
    - Change the `userId` in the response (mentally or via a mock server if you can figure that out).
    - Actually, just write a C# Console App (using `HttpClient`) that fetches this data and prints the Title.
    *(See `src/Exercise.cs` stubs - wait, this module usually doesn't have C# yet, but you can try!)*