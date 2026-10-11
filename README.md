# Sistema de Diálogo Simples | Simple Dialogue System

Um sistema de diálogo simples e reutilizável, desenvolvido em **Unity e C#** para jogos 2D.

O projeto foi criado com o objetivo de oferecer uma solução leve para exibir diálogos entre personagens, mantendo a implementação fácil de entender, configurar e reutilizar em diferentes projetos.

## Funcionalidades

- Exibição sequencial de textos de diálogo
- Suporte a múltiplas linhas de diálogo
- Exibição do nome do personagem
- Avanço dos diálogos por meio da entrada do jogador
- Integração com a interface de usuário (UI)
- Estrutura simples e reutilizável
- Configuração facilitada pelo Inspector da Unity

## Tecnologias utilizadas

- **Unity**
- **C#**
- **Unity UI**

## Como funciona

O sistema de diálogo é responsável por controlar o fluxo de uma conversa.

Um diálogo é composto por várias linhas de texto. Quando iniciado, o sistema exibe a primeira linha e aguarda a entrada do jogador para avançar. Esse processo continua até que todas as linhas tenham sido exibidas e a conversa seja finalizada.

A proposta é manter uma estrutura simples, facilitando a reutilização do sistema em diferentes cenas e projetos.

## Estrutura básica

```text
Sistema de Diálogo
│
├── Dados do Diálogo
│   ├── Nome do Personagem
│   └── Linhas de Diálogo
│
├── Controlador de Diálogo
│   ├── Iniciar Diálogo
│   ├── Exibir Linha
│   └── Avançar Diálogo
│
└── Interface de Diálogo (UI)
    ├── Nome do Personagem
    └── Texto do Diálogo
```

## Configuração

1. Adicione os componentes do sistema de diálogo ao projeto Unity.
2. Configure a interface de diálogo (UI).
3. Defina o nome do personagem e as linhas de diálogo.
4. Conecte o controlador de diálogo aos elementos da interface.
5. Inicie o diálogo por meio da interação ou do evento configurado.

## Exemplo de diálogo

```text
Emma:
"Onde estou?"

Desconhecido:
"Você não deveria estar aqui."

Emma:
"O que você quer dizer?"
```

O jogador pode avançar pelas falas até que o diálogo seja concluído.

## Objetivo do projeto

Este projeto faz parte do meu **portfólio de sistemas reutilizáveis em Unity e C#**, com foco no desenvolvimento de sistemas de gameplay que possam ser adaptados a diferentes jogos e projetos.

## Conhecimentos praticados

- Programação em C#
- Desenvolvimento de interfaces com Unity UI
- Desenvolvimento baseado em componentes
- Controle do fluxo de diálogos
- Criação de sistemas reutilizáveis
- Organização da lógica e da apresentação
- Interações baseadas em entrada do jogador e eventos

## Status do projeto

**Concluído**

O sistema foi desenvolvido com uma proposta simples, podendo servir como base para futuras implementações, como:

- Escolhas de diálogo
- Conversas com ramificações
- Retratos de personagens
- Efeito de digitação do texto
- Eventos associados aos diálogos
- Suporte a localização e tradução
- Salvamento do progresso dos diálogos

## Autor

**Marcus Vinicius Moreira Maria**

Unity Game Developer | Gameplay Programmer | Jogos 2D

[GitHub](https://github.com/marcusvinimoreira)
