# BlazorDbzPersonagem

Aplicação Blazor (.NET 8) que consome a [Dragon Ball API](https://dragonball-api.com/api/characters/1).

O usuário informa o **ID** do personagem e a aplicação exibe:

- **Nome**
- **Planeta de origem**
- **Transformações**

## Como executar

```bash
dotnet run
```

Depois abra o endereço mostrado no terminal (ex.: `https://localhost:5001`).

## Estrutura principal

- `Models/Personagem.cs` – classes que mapeiam o JSON da API
- `Components/Pages/Home.razor` – tela de busca e exibição do personagem
- `Program.cs` – registro do `HttpClient` com a URL base da API
