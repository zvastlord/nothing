#by Nothing
#fb.com/rafael.barbosa.37201901
import sys

print("#####################################")
print("######## Prova de Matemática ########")
print("#####################################\n\n\n")

while True:
	nome = input("Digite seu Nome:")
	contador = 0
	print("Questão Número 1:")
	print("Quanto é 690/3 ?")
	resp1 = int(input("Digite Sua Resposta: "))
	print("Questão Número 2:")
	print("Quanto é 19x19?")
	resp2 = int(input("Digite Sua Resposta: "))
	print("Questão Número 3:")
	print("Quanto é 15x24?")
	resp3 = int(input("Digite Sua Resposta: "))
	print("Questão Número 4:")
	print("Quanto é 469x21?")
	resp4 = int(input("Digite Sua Resposta: "))
	print("Questão Número 5:")
	print("Quanto é 30x18?")
	resp5 = int(input("Digite Sua Resposta: "))
	print("Questão Número 6:")
	print("Quanto é 382x12?")
	resp6 = int(input("Digite Sua Resposta: "))
	print("Questão Número 7:")
	print("Quanto é 424x7?")
	resp7 = int(input("Digite Sua Resposta: "))
	print("Questão Número 8:")
	print("Quanto é 645x14?")
	resp8 = int(input("Digite Sua Resposta: "))
	print("Questão Número 9:")
	print("Quanto é 781x13?")
	resp9 = int(input("Digite Sua Resposta: "))
	print("Questão Número 10:")
	print("Quanto é 174x142?")
	resp10 = int(input("Digite Sua Resposta: "))

# Fim das Questões, agora uso do IF pra dar a nota
	if resp1 == 230:
		contador += 1
	if resp2 == 361:
		contador += 1
	if resp3 == 360:
		contador += 1
	if resp4 == 9849:
		contador += 1
	if resp5 == 540:
		contador += 1
	if resp6 == 4584:
		contador += 1
	if resp7 == 2968:
		contador += 1
	if resp8 == 9030:
		contador += 1
	if resp9 == 10153:
		contador += 1
	if resp10 == 24708:
		contador += 1
	print("Sua nota é:",contador)
	if contador > 9:
	print("Parabéns! você tirou a nota máxima")
	print("Deseja fazer a Prova Novamente?")
	menu = int(input("1- Sim\n2-Não"))
	if menu == 1:
		print("here we go again!")
	if menu == 2:
		sys.exit(0)
