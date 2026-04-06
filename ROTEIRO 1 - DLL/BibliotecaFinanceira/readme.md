6
O método internal só pode ser acessado dentro do mesmo projeto onde foi criado. Como a DLL e o Console são projetos separados, o Console não consegue enxergar métodos internal, apenas os public. 
