import requests
import json
import sys

url = 'http://api.openweathermap.org/data/2.5/weather?q='
key = '&appid=c88d8bb00f7d2c907a40bc9ea6118652'
texto = '''
                                                  
                                                  
        ,UBBBBBBBBBBM5r.                          
      2BBBB0L:    .iUOBBBG,    7MBBBBBBBB7        
    vBBB7                JBi 0BBB1:  :2BBBBM.     
   SBBX    iOBBBOr         .BBY          iBBBj    
  :BBk   5BBBBBBBBBS       BB   :BBBBBBU   kBBF   
  EBB   BBN       BBB     8B   ZB:   ;BBB   FBB,  
  MBB  kBB         BB5    BB  :B       JBB   BB0  
  2BB  1BM   J2B2   BB    BBv  BB.Y5    BB   MBM  
   BB:  BBv    BB   BO    :BB.  7UJ    :BB   BBY  
   iBB   UBBBBBB.  rB,     7BBj       7BB    BB   
    rBB,    ..    7BY        MBBBMEBBBBB    MB,   
      BBBY     iGBB:           rBBBBBY     SBr    
        5BBBBBBBB:   uBBBB0r              8Bi     
         ,        .BBBUi:7NBBB:         .BB       
        iM       GBB         GBB       XBk        
        .B      BBq   ;BBBB.  :BB  .:XBF          
         BU     BB.   B:  iB,  LBr.v7:            
         0B     BBY    i   BB   BZ                
          BB    7BB.      ,BB  ,BG                
          ,BB    jBBN.  :MBB   BB7                
           iBBL    BBBBBBB7   GBB                 
             BBBu           rBBB                  
              7BBBBU:    i8BBBY                   
                iBBBBBBBBBBB7                     
                   :;7v7i,                        
 ############################################
 ######## Consulta da Temperatura ###########
 ############################################
 '''
print(texto)
while True:
	try:
		city = input("\nDigite a cidade:")
		req = requests.get(url+city+key)
		arq = open('arquivo.txt','w')
		jotason = json.loads(req.text)
		arq.writelines(req.text)
		jj = jotason['main']['temp']
		kk = int(jj)-273.15
		print("\nA Temperatura em",city,"é: %.1f°C" %kk)
	except Exception as erro:
		print("ERRO:",erro)
	print("\nDeseja Consultar Novamente? <s/n>")
	opcao = input("Digite sua escolha:")
	if opcao == 'n' or opcao == 'N':
		sys.exit(0)
