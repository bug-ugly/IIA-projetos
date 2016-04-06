# IIA-projetos
projetos de grupo desenvolvidos na cadeira de IIA, universidade de coimbra


Done:

- Ao prefab do objeto "crate" foi adicionado um tag "crate" para corrigir um problema do port 
- associado o script "BreadthFirstSearch" à class "Map" dentro do script "map" para testar o funcionamento
- foi criado o script DepthSearch - the first test resulted in Expanded: 108, Path Length: 21, Visited 108 , this doesn't seem to efficient.  
- foi criado o script Profundidade Limitada (SearchProfLim) - Neste caso foi usado um Stack para que o último nó a ser visto seja o primeiro a ser tratado.
- associado o script "SearchProfLim" à class "Map" dentro do script "map" para testar o funcionamento.
- Foi feito um teste inicial com limite = 10 - nada aconteceu.
- Depois de avaliada a situação chegou-se à conclusão que são necessários no mímino 13 passos (não repetidos; 21 passos no total) para o bloco ficar na posição pretendida. Tendo em conta que cada passo é um nó, o limite tem de ser superior a 14 para que seja encontrada solução.
- o "iterative deepening search" script foi adicionado. It is questionable (must be consulted with the teacher or someone else!)´
- bug-ugly-patch-3 iterative deepening search e depth limited search estao corrigidos. Iterative e limited sao feitos!
- pesquisa sofrega esta feita! 

To Do:

- implementar A*
- RELATÓRIO!
