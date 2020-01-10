# conversor em tempo real de dólar pra real e de real pra dólar, by Nothing ~
# fb.com/rafael.barbosa.37201901
import sys
import requests
import json

texto = """
                                                  
                                                  
                       BBPZ0                      
                      .BFU15                      
                   ,irr777LjjJ7i.                 
                :L5S5jvr;r7vYu2FS27.              
              :j2jv7ri:iii;;i:;77LU2r             
             Yu7;iii:2Bq:::YBXi:iir7Y7            
            Bk::::::7v:..:,:SMqi..,::;:           
           LB,.:::,:    ,:,.  F17L777YY           
           XB .,,,,:   7r...  ,BBBBBBBi           
           70. ....,:  Bv .:                      
            NJ  ....,,.7:..:                      
            :B0:   ...   .....                    
             :BBBL.      ....,,,,::.              
               7BBBBqLi.  ..  .....,,,            
                  :2BBBBL .:Fi.......,:           
                       Bj  rBBX:....,,::          
                       B; ..  :i.,,,,,,i          
          ,jriiii:i    1i..:   .:::::::r          
          :U;:iiii;:   qv.:;   LL::::::v          
           Yviiiiiir:  BX.:7  .ui:iii:v,          
           ,Uviiii;rvr:kL:i7iiriiiiiiY:           
            :1U7iiirrri::;r7L7r;iiij2:            
              uBB8jr;iiir77riii7U0OL              
                JMBBBBMq77rUBBBB0i                
                    ,;ui,LrU7,                    
                        LOMU                      
                       :LJ7      
"""
print(texto)
print("           ###########################")
print("           ####Conversor de Moedas####")
print("           ###########################")
hehe = True
while hehe:
	print("\nMENU:\n1-Real para Dólar\n2-Dólar para Real\n3-Sair\n")
	opcao = int(input("Digite sua Escolha:"))
	if opcao == 1:
		try:
			valor = input("\nEntre com o valor para ser Convertido: ")
			req = requests.get('https://api.vitortec.com/currency/converter/v1.2/?from=BRL&to=USD&value='+valor)
			dicio = json.loads(req.text)
			data = dicio['data']
			print("\nO Valor Digitado Foi: ",data['value'],"Reais")
			print("\nO Valor em Dólar é: ",data['resultSimple'],"Dólares")
		except Exception as erro:
			print("Erro:",erro)
	if opcao == 2:
		try:
			valor = input("Entre com o valor para ser Convertido: ")
			req = requests.get('https://api.vitortec.com/currency/converter/v1.2/?from=USD&to=BRL&value='+valor)
			dicio = json.loads(req.text)
			print("O Valor Digitado Foi: ",data['value'],"Dólares")
			print("O Valor em Reais é: ",data['resultSimple'],"Reais")
			print(dicio['data'])
		except Exception as erro:
			print("Erro:",erro)
	if opcao == 3:
		print("Até Logo!")
		sys.exit(0)
