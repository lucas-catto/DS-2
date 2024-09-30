print("Hello World")

ano = int(input("Digite o ano que você nasceu: "))
anoAtual = 2024

idade = anoAtual - ano

print("A idade atual é:" , idade)

if idade >= 18:
    print("Você é maior de idade!")
    
elif idade >= 16:
    print("Você já pode votar, parabéns?")
    
else:
    print("Café com leite!")