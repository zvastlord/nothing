try:
	nomedoarquivo = "001.txt"
	contador = 1
	while True:
		open(nomedoarquivo, 'w')
		nomedoarquivo = nomedoarquivo + 'a'
		contador += 1
		if contador == 70: #caso queira lascar tudo, só tirar esse if c:
			break
except Exception as erro:
	print("Error:",erro)
