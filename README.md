# The-Fat-Swordman 

Este projeto academico é a construção de um jogo que será construido usando boa parte 
dos conceitros de POO, pois por cada um de seus componentes serem intrissicamente ligados
com todos os demais, assim levando em considerção os principais conceitos como herança, 
polimorfismo e etc.

Uma das principais discuções que tivemos foi sobre o jogo num geral e todos os seus
principais componentes; 
logo abaixo será comentado quais são esses principais aspectos/classes e objetos:

• Jogador
• Inimigo
• Armas
• Mapas
• Itens

Com isso conseguimos definir como tudo estaria conectado ,
como por exemplo o que conecta a classe jogador da classe inimigo
poderia ser uma classe chamada personagem a qual possuiria atributos que serão
usados por todos como por exemplo o atributo movimentação o qual ambas as
classes precisam e fica muito mais fácil de se trabalhar.
Temos também como maior exemplo de polimorfismo os inimigos, dentro do jogo
teremos uma diversidade de inimigos, cada qual com seus atributos únicos como
vida e danos diferentes, ou seja, uma classe que está assumindo diversas formas
diferentes.

E para finalizar, temos o conceito de abstração, o qual irá servir para criar imersão
ao jogador, pois a partir desse conceito conseguimos fazer com que ele se sinta
mais conectado ao jogo, sendo feito assim de uma forma mais orgânica, como por
exemplo o atributo pular ou correr, o jogador não precisa entender necessariamente
como ele acontece, ele só precisa realizar essas ações de certa forma complexas,
mas que são intuitivas e simples ao jogador de se executar.

----------------------------------------------------------------------------------------

Um de nossos princripais guias para a evolução de nosso projeto foi a criação de um Diagtrama
UML o que sera demonstrado a baixo:

[Projeto POO.pdf](https://github.com/user-attachments/files/23616794/Projeto.POO.pdf)

E com temos uma boa base de como todas as classes estariam funcionando.

----------------------------------------------------------------------------------------

Uma de nossas princripais dificuldades seria a flata de experiencia dos demais que
nunca haviam tido a experiência de se criar um jogo, o nosso integrante que possui
estas skills é João o qual ficou encarregado da maior parte de programação e de sua logica
e os demais tinham que implementar pequenas mudanças, ja nosso membro que tinha o computador
mais simples ficou responsavel pela documentação e pelos registros de avanço. 

🚀 Instruções de Instalação e Uso (Unity)
📦 Pré-requisitos
Unity Hub instalado (download oficial)

Versão recomendada do Unity Editor (exemplo: 2021.3 LTS ou a versão que você usou no projeto)

Git instalado para clonar o repositório (download oficial)

🔧 Instalação
Clonar o repositório

bash
git clone https://github.com/SEU_USUARIO/NOME_REPOSITORIO.git
ou baixe o .zip direto do GitHub.

Abrir no Unity Hub

Abra o Unity Hub

Clique em Add

Selecione a pasta do projeto clonado

Selecionar a versão correta do Unity

Certifique-se de que a versão do Unity usada no projeto está instalada

Se não estiver, instale pelo Unity Hub

▶️ Uso
Abrir o projeto no Unity Editor pelo Unity Hub

Carregar a cena principal

Vá até a pasta Assets/Scenes/

Abra a cena inicial (exemplo: Menu.unity ou SampleScene.unity)

Rodar o jogo

Clique no botão Play dentro do Unity Editor

Build do jogo (opcional)

Vá em File > Build Settings

Escolha a plataforma (Windows, Mac, Android, etc.)

Clique em Build para gerar o executável
