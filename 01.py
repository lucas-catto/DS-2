
from random import randint

print("============ SORTEIO ============")

numeroSorteado = randint(0, 10)
tentativas = 1

print("SE FOR ESSE NUMERO VC GANHA", numeroSorteado)

while tentativas <= 5:
    numeroEscolhido = int(input("Digite o número de 0 a 10: "))
    tentativas += 1
    
    if numeroEscolhido == numeroSorteado:
        print("Parabéns você ganhou")
        break
    
    if numeroEscolhido > 10 or numeroEscolhido < 0:
        print("Por favor informe um número entre 1 e 10!")
        tentativas -= 1
    
    elif tentativas > 5:
        print("Infelizmente você perdeu, sinto muito!")
        
    else:
        print("Tente Novamente")
