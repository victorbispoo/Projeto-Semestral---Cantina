# 🥪 Projeto Semestral — Sistema de Cantina (Windows Forms - C#)

Este é um sistema de gerenciamento de cantina escolar desenvolvido como projeto semestral acadêmico(SENAI), utilizando a linguagem C# e a plataforma Windows Forms. O objetivo principal é simular o funcionamento de uma cantina com módulos distintos para o balcão, a cozinha e o menu.

## 🎯 Funcionalidades

- Interface gráfica com múltiplas telas (Balcão, Cozinha, Menu, Telão de retirada)
- Cadastro e gerenciamento de pedidos e produtos
- Comunicação entre os módulos de atendimento e preparo dos pedidos
- Persistência de dados via arquivos locais (em breve: salvamento no HDD)
- Futuramente realizarei a implementação de um sistema de estoque (integrado e sincronizado)

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET Framework (Windows Forms)
- **Interface:** Windows Forms (`.cs`, `.Designer.cs`, `.resx`)
- **Armazenamento:** Arquivos locais *(futuramente: HDD local)*

## 📦 Estrutura do Projeto

- `Balcao.cs`, `Cozinha.cs`, `Menu.cs`: Telas principais do sistema
- `Pedido.cs`: Lógica dos pedidos realizados
- `PersistenciaPedido.cs`: Manipulação de arquivos para salvar os dados
