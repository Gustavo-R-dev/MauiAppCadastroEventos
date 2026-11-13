# 📱 App de Cadastro de Eventos (.NET MAUI)

Aplicativo desenvolvido em **.NET MAUI** com o objetivo de gerenciar o cadastro de eventos, calculando de forma automatizada a duração em dias e o custo total com base na quantidade de participantes.

## 🚀 Funcionalidades
* **Cadastro de Eventos:** Registro de nome, local, data de início e término.
* **Seleção de Participantes e Custos:** Definição da quantidade de participantes e do custo unitário por pessoa.
* **Cálculo Automático (`TimeSpan` & `DateTime`):** Calcula a duração exata do evento em dias.
* **Cálculo de Custos:** Apresenta o custo total formatado em Reais (`R$`).
* **Tela de Resumo (`BindingContext`):** Exibe todas as informações consolidadas em uma página dedicada.

## 🛠️ Tecnologias Utilizadas
* **.NET MAUI** (Multi-platform App UI)
* **C#**
* **XAML**

## 📂 Estrutura do Projeto
* **Models/Evento.cs:** Classe de modelo responsável pelas regras de negócio, cálculo de dias (`TimeSpan`) e cálculo de custo total.
* **Views/CadastroEvento.xaml:** Tela principal de entrada de dados.
* **Views/EventoCadastrado.xaml:** Tela de resumo que recebe os dados via passagem de parâmetros e faz o *Data Binding*.
