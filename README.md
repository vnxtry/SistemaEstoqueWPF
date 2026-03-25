Sistema de Integração de Estoque (WPF)
(EXEMPLO DE IMAGEM: banner_do_projeto.png - Uma imagem de capa bonita com o nome do projeto e logos do C# e WPF)

Este projeto foi desenvolvido como requisito para a Situação de Aprendizagem (SA). O objetivo principal é demonstrar a aplicação prática de Padrões de Projeto (GoF) e boas práticas de arquitetura utilizando C# e Windows Presentation Foundation (WPF).

📖 A Origem do Padrão Adapter (Gang of Four)
O padrão Adapter não surgiu do nada. Ele faz parte de um catálogo lendário no mundo da engenharia de software criado por quatro autores: Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides.

Juntos, eles ficaram conhecidos como a "Gang of Four" (Gangue dos Quatro, ou GoF). Em 1994, eles publicaram o livro "Design Patterns: Elements of Reusable Object-Oriented Software". O objetivo deles não era inventar código novo, mas sim catalogar soluções brilhantes e repetíveis para problemas comuns que os programadores enfrentavam todos os dias na Orientação a Objetos.

Eles classificaram o Adapter como um Padrão Estrutural. Segundo o GoF, a intenção oficial do Adapter é "converter a interface de uma classe em outra interface esperada pelos clientes, permitindo que classes trabalhem em conjunto, o que de outra forma seria impossível devido a interfaces incompatíveis". É exatamente esse conceito histórico que este projeto traz para a prática!

(EXEMPLO DE IMAGEM: livro_gof_ou_autores.png - Uma foto da capa do livro Design Patterns do GoF ou uma ilustração com os 4 autores)

🔌 Padrão de Projeto Aplicado: Adapter (Estrutural)
O cenário do nosso sistema simula a necessidade de uma empresa importar dados de um sistema ERP Legado, cujas classes e propriedades são totalmente incompatíveis com o sistema de estoque moderno atual.

Para resolver essa incompatibilidade de interfaces sem modificar o código existente (respeitando o princípio Open/Closed do SOLID), foi implementado o padrão Adapter.

(EXEMPLO DE IMAGEM: diagrama_uml_adapter.png - Um diagrama UML mostrando a relação entre o Target, Adaptee e o Adapter no seu código)

Target (O Alvo): IFornecedor e ProdutoModerno — Representa o que o sistema novo espera receber e entende.

Adaptee (O Incompatível): SistemaErpAntigo e ProdutoAntigo — O sistema velho, com dados em formatos diferentes e métodos obsoletos.

Adapter (O Tradutor): ErpAdapter — A classe mágica que implementa a interface do sistema novo, mas consome os dados do sistema velho, fazendo a ponte (adaptação) entre os dois mundos.

🏗️ Arquitetura e Boas Práticas (MVVM)
Além do Padrão de Projeto exigido, o sistema foi refatorado e desenhado utilizando a arquitetura MVVM (Model-View-ViewModel), o padrão ouro para aplicações WPF.

(EXEMPLO DE IMAGEM: print_da_tela_funcionando.png - Uma screenshot do sistema rodando, mostrando a interface WPF com os dados importados)

Separação de Responsabilidades: O MainWindow.xaml.cs (Code-Behind) é extremamente limpo e não possui regras de negócio, lidando apenas com a inicialização.

Data Binding e Commands: A interface gráfica (View) se comunica de forma reativa com a lógica (ViewModel) através de Bindings e do uso de ICommand (implementado via RelayCommand).

Mock de Banco de Dados: Para facilitar a execução, a avaliação do projeto e focar puramente no Design Pattern, os dados do sistema legado foram mockados direto na classe SistemaErpAntigo. Isso elimina a necessidade de rodar scripts de banco de dados e garante que o projeto rode "de primeira" em qualquer máquina.

🚀 Como executar o projeto
Clone este repositório para a sua máquina:

Bash
git clone https://github.com/vnxtry/SistemaEstoqueWPF.git
Abra o arquivo da solução (.sln) na sua IDE de preferência (JetBrains Rider ou Visual Studio).

Defina o projeto WPF como Startup Project (Projeto de Inicialização).

Execute o projeto pressionando F5 ou clicando no botão Play.

Na tela inicial, clique no botão "Importar Produtos do ERP Antigo" para ver a mágica do padrão Adapter funcionando em tempo real.

🛠️ Tecnologias Utilizadas
Linguagem: C#

Framework: .NET

Interface Gráfica: Windows Presentation Foundation (WPF)

Paradigma: Programação Orientada a Objetos (POO)

Design Patterns: Adapter (GoF)

Arquitetura: MVVM (Model-View-ViewModel)
