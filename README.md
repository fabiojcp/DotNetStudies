# PostController

To Run:
<ol>
  <li>Open CLI
    <ul>
      <li>Run <code>cd MyWebApi</code></li>
      <li>Run <code>cd WeatherForecast</code></li>
      <li>Run <code>dotnet run Program.cs</code></li>
      <li>For a custom PORT, run <code>dotnet run Program.cs --urls=http://localhost:PORT</code></li>
    </ul>
  </li>

  <li>Endpoints

    **GetPosts:**
    - **Method:** GET
    - **Route:** `/Post`
    - **Description:** Retrieves all posts.

    **CreatePost:**
    - **Method:** POST
    - **Route:** `/Post`
    - **Description:** Creates a new post.
      - **Request Body:**
        - `Id` (optional): The unique identifier of the post.
        - `Title`: The title of the post.
        - `Content`: The content of the post.
        - `Author`: The author of the post.
      - **Request Body Example:**
        ```json
        {
          "title": "Chronicles of the Enchanted Forest",
          "content": "In a realm cloaked in emerald shadows and whispers of magic, the Enchanted Forest beckons adventurers with its ancient secrets. A lone wanderer, guided by the luminous glow of mystical fireflies, embarks on a quest through the towering trees and dew-kissed ferns.",
          "author": "John Doe"
        }
        ```

    **GetPostById:**
    - **Method:** GET
    - **Route:** `/Post/{id}`
    - **Description:** Retrieves a post by its unique identifier.
  </li>

  <li>Usage

    1. Open the command line interface (CLI).
      - Run `cd MyWebApi`.
      - Run `cd WeatherForecast`.
      - Run `dotnet run Program.cs`.
      - For a custom PORT, run `dotnet run Program.cs --urls=http://localhost:PORT`.

    2. Access the API's documentation.
      - Endpoint: `GET /swagger/index.html`.
  </li>
</ol>



# WeatherForecast

To Run:
<ol>
<li>Open CLi
<ul>
<li>run <code>cd MyWebApi</code></li>
<li>run <code>cd WeatherForecast </code></li>
<li>run <code>dotnet run Program.cs</code></li>
<li>for a custom PORT <code>dotnet run Program.cs --urls=http://localhost:PORT</code></li>
</ul> 
</li>

<li>Route

**Endpoint:** `GET /WeatherForecast`

**Description:** Example of weather forecasts for the next 5 days.
</li>

<li>Docs

**Endpoint:** `GET /swagger/index.html`
</li></ol>