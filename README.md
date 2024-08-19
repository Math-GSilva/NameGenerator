# Gerador de Nomes Aleatórios

## Descrição

O **Gerador de Nomes Aleatórios** é uma aplicação de console desenvolvida para gerar nomes aleatórios com base em parâmetros fornecidos pelo usuário. A aplicação utiliza as bibliotecas [Bogus](https://github.com/bchavez/Bogus) para gerar os nomes e [NLog](https://github.com/NLog/NLog) para o registro de logs. O projeto foi desenvolvido por Matheus Gabriel da Silva e Larissa Hoffmann de Souza.

## Propósito

O objetivo deste projeto é fornecer uma ferramenta simples e eficaz para a geração de nomes aleatórios. É útil para testes de software, criação de perfis fictícios ou qualquer situação em que nomes aleatórios sejam necessários.

## Funcionalidades

- **Escolha da Primeira Letra**: Permite ao usuário definir a primeira letra do nome gerado.
- **Seleção de Gênero**: Permite ao usuário escolher entre nomes masculinos, femininos ou gerar nomes aleatórios.
- **Quantidade de Nomes**: Permite ao usuário definir o número de nomes a serem gerados.
- **Registro de Logs**: Utiliza o NLog para registrar informações, avisos e erros durante a execução do programa.

## Uso

Ao executar a aplicação, você será solicitado a fornecer as seguintes informações:

1. **Primeira Letra**:
   - **Prompt**: "Escolha a primeira letra do nome (deixe em branco para qualquer letra):"
   - **Descrição**: Informe a letra com a qual o nome gerado deve começar. Se deixar em branco, qualquer letra será utilizada.

2. **Gênero**:
   - **Prompt**: "Escolha o sexo do nome (M/F ou deixe em branco para aleatório):"
   - **Descrição**: Informe o gênero do nome desejado:
     - **M** para masculino
     - **F** para feminino
     - Deixe em branco para gerar nomes de qualquer gênero.

3. **Quantidade de Nomes**:
   - **Prompt**: "Quantos nomes você deseja gerar?"
   - **Descrição**: Informe o número de nomes que você deseja gerar. Se a entrada não for um número válido ou for menor ou igual a zero, o programa irá gerar apenas um nome por padrão.

4. **Continuar Gerando**:
   - **Prompt**: "Deseja gerar mais nomes? (S/N):"
   - **Descrição**: Escolha se deseja gerar mais nomes ou encerrar o programa. Digite **S** para continuar ou **N** para finalizar.

## Feito por
- **Matheus Gabriel da Silva**
- **Larissa Hoffmann de Souza**
