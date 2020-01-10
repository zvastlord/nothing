try:
	nomedoarquivo = 0
	contador = 1
	while True:
		open(str(nomedoarquivo)+'.txt', 'w')
		nomedoarquivo = int(nomedoarquivo) + 1
		contador += 1
		if contador == 10: #caso queira lascar tudo, só tirar esse if c:
			break
except Exception as erro:
	print("Error:",erro)
