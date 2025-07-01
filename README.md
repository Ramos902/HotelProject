# 🏨 HotelProject

Projeto desenvolvido com o intuito de praticar os fundamentos da linguagem C# e a programação orientada a objetos, simulando um sistema de reservas de suítes em um hotel.

## 💡 Objetivo

O objetivo deste projeto é representar um sistema simples de hotelaria, no qual é possível:

- Criar diferentes tipos de suítes;
- Registrar reservas com quantidade de dias;
- Adicionar hóspedes (respeitando a capacidade da suíte);
- Calcular o valor total da reserva com base na diária e dias reservados;
- Imprimir informações sobre reservas e suítes.

## 🧱 Estrutura

O projeto é dividido em:

- **Entities**
  - `Suite`: representa uma suíte do hotel, contendo tipo, capacidade e valor da diária.
  - `Peaple`: representa um hóspede (pessoa).
- **Utilities**
  - `Reservations`: classe responsável por gerenciar as reservas, adicionar hóspedes e calcular os custos.
- **HotelProject**
  - `Program.cs`: ponto de entrada da aplicação, onde são instanciadas suítes, reservas e hóspedes.

## 🚀 Como usar

1. Clone o repositório:
   ```bash
   git clone https://github.com/Ramos902/HotelProject.git
   ```

2. Abra o projeto em um editor como Visual Studio ou VS Code com extensão C# instalada.

3. Compile e execute:
   ```bash
   dotnet build
   dotnet run
   ```

4. Acompanhe a saída no console com as informações da suíte, reservas e hóspedes adicionados.

## 📌 Observações

- O projeto está em fase de aprendizado e pode receber melhorias futuras como:
  - Cadastro de múltiplas reservas dinâmicas;
  - Interface de usuário;
  - Persistência de dados.
