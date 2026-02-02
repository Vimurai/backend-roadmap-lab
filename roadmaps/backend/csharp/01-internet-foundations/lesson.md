# 01 Internet Foundations: The Postal Service

## 🧠 Mental Model: The Restaurant & The Mail
The Internet is not a cloud; it's a wire.
- **You (Client):** The hungry customer.
- **Browser/App:** The waiter.
- **Server:** The kitchen.
- **Request:** The order ticket.
- **Response:** The plate of food (or a note saying "We're out of tacos" - 404).

## 🪝 Memory Hook
> *"Client Asks, Server Serves."*

## 📚 Core Concepts

### 1. IP Address vs. DNS
- **IP Address (142.250.190.46):** The GPS coordinates of the house.
- **DNS (google.com):** The address book entry. Humans remember names; computers remember numbers.

### 2. HTTP Methods (The Verbs)
- **GET:** "Can I see the menu?" (Read)
- **POST:** "Here is my order." (Create)
- **PUT:** "Change my order to steak." (Replace)
- **DELETE:** "Cancel my order." (Delete)

### 3. Status Codes (The Result)
- **200 OK:** "Here is your food."
- **400 Bad Request:** "You asked for a 'Grumple'. We don't serve that." (Client error)
- **401 Unauthorized:** "You need to pay/signin first."
- **404 Not Found:** "The waiter can't find table 99."
- **500 Server Error:** "The chef set the kitchen on fire." (Server error)

## ⚠️ Common Mistakes
- **Confusing Client and Server:** Thinking the browser "runs" the website. The browser just *displays* what the server sent.
- **Ignoring Headers:** Metadata (like Content-Type) is crucial. It's the "Allergy Info" on the ticket.
- **Thinking HTTP is secure:** Without the 'S' (HTTPS), anyone with a wiretap can read your postcard.

## 📝 Mini Quiz
1.  What does DNS stand for?
2.  If I want to *send* a form to a server, which HTTP verb should I use?
3.  What specific status code means "I can't find that page"?
4.  What is "localhost"?
5.  What port does HTTP usually run on? (80 or 443?)

## 🛠️ Practice Tasks
1.  Open your browser's Developer Tools (F12).
2.  Go to the "Network" tab.
3.  Refresh the page.
4.  Look at the first request. What is the Status Code?

## 💭 Reflection
*   Write 3 bullets on what happens between hitting "Enter" in the URL bar and seeing the page.
*   Why do we need DNS?