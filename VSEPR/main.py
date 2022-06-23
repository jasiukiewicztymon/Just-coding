"""
Table printing -> AA
"""

class formulaException(Exception):
    pass

def drawFormula(A, X, Xn, E = None, En = None):
    """
    A   - Atome central
    X   - Une paire liante
    Xn  - Nombre de paire liante
    E   - Une paire non-liante  (|, -)
    En  - Nombre de paire non-liante

    Xn + En <= 4
    """
    if E == None:
        if Xn > 4:
            raise formulaException("Un nombre invalide de paire liante")
        if Xn == 2:
            print(X, ' - ', A, ' - ', X)
        elif Xn == 3:
            tab = 0
            if len(A) % 2 != 0:
                tab = 1
            print(((len(X) + 1) + int(len(A) / 2 - len(X) / 2) + 1) * ' ', X)
            print(((len(X) + 1) + int(len(A) / 2) + 1) * ' ', '|')
            print(((len(X) + 1 + int(len(A) / 2) + 1) - int(len(A) / 2) - tab + 1)*' ', A)
            print(len(X)*' ', '/', (len(A) + 1 - tab)*' ', '\\')
            print(X, (len(A)+4)*' ', X)
        else:
            tab = 0
            if len(A) % 2 != 0:
                tab = 1
            print(((len(X)+3) + int(len(A)/2-len(X)/2)+1)*' ', X)
            print(((len(X)+3) + int(len(A)/2)+tab)*' ', '|')
            print(X, ' - ', A, ' - ', X)
            print(((len(X)+3) + int(len(A)/2)+tab)*' ', '|')
            print(((len(X)+3) + int(len(A)/2-len(X)/2)+1)*' ', X)
    else:
        if Xn + En > 8 or Xn > 3 or En > 3:
            raise formulaException("Un nombre invalide de paire liante et non-liante")
        if Xn == 2 and En == 1:
            tab = 0
            if len(A) % 2 != 0:
                tab = 1
            print(((len(X) + 1) + int(len(A) / 2) + 1) * ' ', '_')
            print(((len(X) + 1 + int(len(A) / 2) + 1) - int(len(A) / 2) - tab + 1) * ' ', A)
            print(len(X) * ' ', '/', (len(A) + 1 - tab) * ' ', '\\')
            print(X, (len(A) + 4) * ' ', X)
        elif Xn == 2 and En == 2:
            tab = 0
            if len(A) % 2 != 0:
                tab = 1
            print(((len(X) + 1) + int(len(A) / 2) - tab) * ' ', '/', (tab)*' ', '\\')
            print(((len(X) + 1 + int(len(A) / 2) + 1) - int(len(A) / 2) - tab + 1) * ' ', A)
            print(len(X) * ' ', '/', (len(A) + 1 - tab) * ' ', '\\')
            print(X, (len(A) + 4) * ' ', X)
        else:
            tab = 0
            if len(A) % 2 != 0:
                tab = 1
            print(((len(X) + 3) + int(len(A) / 2 - len(X) / 2) + 1 + tab) * ' ', '_')
            print(X, ' - ', A, ' - ', X)
            print(((len(X) + 3) + int(len(A) / 2) + tab) * ' ', '|')
            print(((len(X) + 3) + int(len(A) / 2 - len(X) / 2) + 1) * ' ', X)

drawFormula('fddcg', 'kdd', 4)
