# POO

Atividade Prática: Sistema de Notificações Bancárias em C#
Objetivo: Praticar os conceitos fundamentais de Programação Orientada a
Objetos (POO) em C#, incluindo a criação de classes, encapsulamento (atributos
e propriedades com get/set), construtores, métodos e a utilização de Delegates
para criar um sistema simples de eventos/notificações.
Cenário
O "Banco C-Sharp" precisa de um sistema básico para gerenciar as contas de
seus clientes. Uma exigência de segurança recente do banco é que qualquer
saque acima de um valor específico ou que deixe a conta negativa deve
disparar um alerta.
Como o sistema pode enviar esse alerta por e-mail, SMS ou apenas exibir na tela,
a equipe de arquitetura decidiu que o método de saque deve receber um Delegate
apontando para a função de notificação desejada.
Instruções para o Aluno
Você deve criar um programa em C# em modo Console (Console Application) que
atenda aos seguintes requisitos:
Passo 1: O Delegate
Fora ou dentro da sua classe principal, declare um delegate chamado
NotificacaoAlerta que não retorne nada (void) e receba uma string (a mensagem
de alerta) como parâmetro.
Passo 2: A Classe e Atributos
Crie uma classe chamada ContaBancaria. Crie os seguintes atributos privados
(fields):
• _titular (string)
• _saldo (double)
• _limiteExtra (double)
Passo 3: Propriedades (Gets e Sets)
Encapsule os atributos usando Propriedades do C#:
• Titular: Deve ter get e set públicos.
• Saldo: Deve ter um get público, mas o set deve ser privado (o saldo só pode
ser alterado por depósitos e saques).

• LimiteExtra: Deve ter get e set públicos. No set, faça uma validação: o
limite extra não pode ser um valor negativo. Se tentarem atribuir um valor
negativo, o limite deve permanecer 0 e uma mensagem de erro pode ser
impressa no console.
Passo 4: Construtor
Crie um Construtor para a classe ContaBancaria que receba o nome do titular, o
saldo inicial e o limite extra. O construtor deve inicializar as propriedades
correspondentes.
Passo 5: Métodos
Crie dois métodos na classe ContaBancaria:
1. Depositar(double valor): Adiciona o valor ao saldo.
2. Sacar(double valor, NotificacaoAlerta alerta):
o Verifica se o saldo + limite é suficiente para o saque.
o Se for, deduz o valor do saldo.
o A Regra de Negócio do Delegate: Se o valor do saque for maior que
R$ 1.000,00 OU se o saldo da conta ficar negativo após o saque,
invoque o delegate alerta passando uma mensagem de aviso (ex:
"ALERTA: Saque de alto valor ou uso de limite detectado na conta de
[Titular].").

Passo 6: Programa Principal (Main)
Na classe Program (método Main):
1. Crie dois métodos estáticos que combinem com a assinatura do seu
delegate (ex: EnviarEmail(string msg) e EnviarSMS(string msg)). Estes
métodos devem apenas imprimir no console: "Enviando E-mail: [msg]" etc.
2. Instancie um objeto da classe ContaBancaria.
3. Faça testes chamando o método Sacar. Em um dos saques, passe o
método EnviarEmail como delegate. Em outro, passe o método EnviarSMS.
