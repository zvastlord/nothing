# By Nothing ~
# fb.com/rafael.barbosa.37201901
import sys
a = "############################################################"
b = "########### PROVA EM PYTHON, by Nothing ! ##################"
c = "############################################################"
arq = open('dados.txt','w')
print(a)
print(b)
print(c)
print(" ")
print('----------------------------- Primeiros Dados -----------------------------')
print(" ")
nomecompleto = str(input("Digite seu NOME e SOBRENOME: "))
RA = str(input("Informe o Número do Seu RA:"))
print(" ")
print('----------------------------- Escolha a Matéria: ----------------------------')
print(" ")
print('1 - Matemática')
print('2 - História')
print('3 - Sair')
print(" ")
menuzin = False
nota = 0
while menuzin == False:
    print(" ")
    menu = int(input('Informe qual será sua decisão: '))
    print(" ")

    if menu ==1:
        notamat = 0
        print("QUESTÃO NUMERO 1:")
        print("Quanto é um numero elevado por 0?")
        print(" ")
        resp = input("Digite sua resposta: ")
        if resp == '1' or resp == 'um' or resp == 'Um':
            print("Parabéns, Você Acertou!")
            print(" ")
            notamat = notamat + 1
        else:
            print("Você Errou!")
            print(" ")
        print("QUESTÃO NUMERO 2:")
        print("Quanto é 3 x 4 ?")
        print(" ")
        resp = input("Digite sua resposta: ")
        if resp == '12' or resp == "doze" or resp == "doze":
            print("Você Acertou !")
            print(" ")
            notamat = notamat + 1
        else:
            print("Você Errou !")
            print(" ")
        print("Sua Nota Final é: ")
        print(notamat)
        notamat = str(notamat)
        arq.writelines("Nota de Matemática:")
        arq.writelines(notamat)
        arq.writelines("\n")
    if menu ==2:
        nota = 0
        print("QUESTÃO NUMERO 1:")
        print("Como era chamado Adolf Hitler por seus seguidores?")
        print(" ")
        resp = input("Digite sua resposta: ")
        if resp == "Fuhrer" or resp == 'Führer' or resp == 'fuhrer' or resp == 'führer':
            print("Você Acertou!")
            print(" ")
            nota = nota + 1
        else:
            print("Você Errou!")
        print("QUESTÃO NUMERO 2:")
        print("Quem descobriu o brasil?")
        print(" ")
        resp = input("Digite sua resposta: ")
        if resp == "Pedro Álvares Cabral" or resp == "Pedro Alvares Cabral":
            print("Você Acertou !")
            print(" ")
            nota = nota + 1
        else:
            print("Você Errou!")
            print(" ")
        print("Sua nota final é:",nota)
        nota = str(nota)
        arq.writelines("Nota de História:")
        arq.writelines(nota)
        arq.writelines("\n")
    if menu ==3:
        print("Até logo !")
        arq.writelines("Nome:")
        arq.writelines(nomecompleto)
        arq.writelines("\n")
        arq.writelines("RA:")
        arq.writelines(RA)
        arq.close
        sys.exit(0)
