# Estacionamento
Parking Control System - A Windows Forms-based desktop application developed in C# for managing vehicle entries and exits in a parking lot. Includes price policies based on validity dates and tracks vehicle movement using license plates as unique identifiers.

# 🅿️ Parking Control System

A desktop application for managing vehicle parking, developed using C# and Windows Forms. The system enables vehicle registration, price configuration with validity dates, and tracking of vehicle entries and exits using license plates.

## 🚀 Features

- Vehicle registration (by license plate, model, etc.)
- Pricing table with start and end validity dates
- Entry and exit recording
- Automatic calculation of the amount due based on price rules
- Windows Forms graphical interface
- Local database support

## 🛠️ Technologies

- C#
- .NET (Windows Forms)
- Local database (see `bancoEstacionamento.sql`)
- Visual Studio

## 🗂️ Project Structure

- `FormCadastroVeiculo.cs`: Vehicle registration form
- `FormCadastroPreco.cs`: Price policy management
- `FormMovimentacao.cs`: Entry/Exit management
- `ConexaoBanco.cs`: Handles database connection
- `bancoEstacionamento.sql`: SQL script to create the database schema

## 💡 Usage

1. Clone this repository.
2. Open the solution (`Estacionamento.sln`) in Visual Studio.
3. Build and run the project.
4. Use the interface to register vehicles, set price rules, and manage parking activity.

## 🧾 License

This project is for educational purposes only. You can modify and use it freely.

---

Feel free to contribute or adapt it for your own parking control needs.
