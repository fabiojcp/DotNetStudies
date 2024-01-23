# PostController

## About
Code implementing an API for creating, reading, and retrieving posts by ID in the .NET 7.0.13 environment.

To Run:
<ol>
  <li>Open CLI
    <ul>
      <li>Run <code>cd Blog</code></li>
      <li>Run <code>dotnet run Program.cs</code></li>
      <li>For a custom PORT, run <code>dotnet run Program.cs --urls=http://localhost:PORT</code></li>
    </ul>
  </li>

  <li>Routes

  **GetPosts:**
  - **Method:** GET
  - **Route:** `/Post`
  - **Description:** Retrieves all posts.

  **CreatePost:**
  - **Method:** POST
  - **Route:** `/Post`
  - **Description:** Creates a new post.
  - **Request Body:**
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

<li>Docs

**Endpoint:** `GET /swagger/index.html`
</li>
</ol>



# WeatherForecast

## About
Code for a weather forecast API, simulation predicting upcoming days' weather conditions.

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

<li>Routes

**Endpoint:** `GET /WeatherForecast`

**Description:** Example of weather forecasts for the next 5 days.
</li>

<li>Docs

**Endpoint:** `GET /swagger/index.html`
</li></ol>
