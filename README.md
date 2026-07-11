# FCG-Shared

Biblioteca compartilhada do projeto **FIAP Cloud Games**.

Este repositório centraliza os contratos de eventos usados na comunicação assíncrona entre os microsserviços. A ideia é manter uma única definição dos eventos publicados e consumidos via RabbitMQ/MassTransit, evitando duplicação de classes em cada serviço.

## Eventos disponíveis

- `UserCreatedEvent`: publicado pela Users API quando um usuário é criado.
- `OrderPlacedEvent`: publicado pela Catalog API quando um pedido de compra é criado.
- `PaymentProcessedEvent`: publicado pelo Payments Worker após o processamento do pagamento.

## Como adicionar como submódulo

Na raiz do projeto que irá consumir os contratos, execute:

```bash
git submodule add https://github.com/IgorAnthonyy/FCG-Shared.git src/submodule/FCG.Shared
git submodule update --init --recursive
```

Depois, referencie o projeto `FCG.Shared.csproj` no `.csproj` do serviço consumidor:

```xml
<ItemGroup>
  <ProjectReference Include="..\submodule\FCG.Shared\FCG.Shared.csproj" />
</ItemGroup>
```

Ajuste o caminho do `ProjectReference` conforme a localização do `.csproj` que está fazendo a referência.

## Como clonar um projeto que usa este submódulo

Ao clonar um repositório que já possui o `FCG-Shared` como submódulo:

```bash
git clone --recurse-submodules <url-do-repositorio>
```

Se o projeto já foi clonado sem os submódulos:

```bash
git submodule update --init --recursive
```

## Como atualizar o submódulo

Para buscar a versão mais recente do `FCG-Shared` dentro de um projeto consumidor:

```bash
git submodule update --remote src/submodule/FCG.Shared
```

Depois disso, faça commit no projeto consumidor para registrar a nova revisão do submódulo.
