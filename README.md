# 🥪 Projeto Semestral — Sistema de Cantina (Windows Forms - C#)

Este é um sistema de gerenciamento de cantina escolar desenvolvido como parte de um projeto semestral acadêmico no **SENAI**, utilizando a linguagem **C#** e a plataforma **Windows Forms**. O objetivo principal é simular o funcionamento de uma cantina com módulos distintos para o balcão, a cozinha, o menu e o telão de retirada de pedidos.

## 🎯 Funcionalidades

- Interface gráfica com múltiplas telas (Balcão, Cozinha, Menu, Telão de Retirada)
- Cadastro e gerenciamento de pedidos e produtos
- Comunicação entre os módulos de atendimento e preparo dos pedidos
- Persistência de dados via arquivos locais (salvamento no HDD em desenvolvimento)
- Implementação futura de um sistema de estoque integrado e sincronizado

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET Framework (Windows Forms)
- **Interface Gráfica:** Windows Forms (`.cs`, `.Designer.cs`, `.resx`)
- **Armazenamento:** Arquivos locais *(futuramente: HDD local)*

## 📦 Estrutura do Projeto

- **`Balcao.cs`**, **`Cozinha.cs`**, **`Menu.cs`**: Telas principais do sistema.
- **`Pedido.cs`**: Lógica de gerenciamento dos pedidos realizados.
- **`PersistenciaPedido.cs`**: Manipulação de arquivos para persistência dos dados.

## 🖨 Prévias do Projeto

### Tela de Vendas
A tela de vendas é onde os pedidos são realizados.
![Tela de Vendas](https://github.com/user-attachments/assets/850d046e-789b-40bc-8f0c-3ebf4b31408a)

### Tela de Pagamento/Conclusão dos Pedidos
Aqui, o cliente informa seu nome, forma de pagamento e tipo de pedido (viagem ou consumo local).
![Tela de Conclusão de Pagamento](https://github.com/user-attachments/assets/c3f210bd-7076-4590-aef8-4e4e679ec803)
![Extrato](https://github.com/user-attachments/assets/c389e5fc-5288-4237-928d-25a7f0c25832)

### Tela da Cozinha
Na tela da cozinha, o status do pedido pode ser atualizado para "Preparando" ou "Pronto".
![Tela da Cozinha](https://github.com/user-attachments/assets/37018bdc-c58e-4e6f-a119-30da84e6d231)

### Tela do Balcão
O balcão é responsável pela entrega dos pedidos prontos aos clientes.
![Tela do Balcão](https://github.com/user-attachments/assets/54009618-e7ea-4f1e-b0b9-770f972eb1bc)

### Telão de Retirada
Inspirado no modelo de fast food, o telão exibe os pedidos prontos para retirada.
![Telão de Retirada](https://github.com/user-attachments/assets/e7bb768c-f6f9-4989-86cd-4923e8c90b3c)
