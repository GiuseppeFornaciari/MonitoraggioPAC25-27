SELECT [IdOutput]
      ,[IdProgetto]
      ,[UltimoAggiornamento]
      ,[CodPriorita]
      ,[ObiettivoRete]
      ,[RisultatiAttesi]
      ,[CodTema]
      ,[CodTipoOutput]
      ,[CodOutputCompleto]
      ,[OutputDescrizione]
      ,[OutputProgrammato]
      ,[OutputRealizzato]
      ,[OutputNonProgrammato]
      ,[NumOutputProgrammato]
      ,[NumOutputRealizzato]
      ,[NumOutputNonProgrammato]
      ,[OutputAllegato]
      ,[OutputLink]
      ,[NoteOutputResponsabileEnte]
      ,[ParereResponsabileMinistero]
      ,[ParereResponsabileMinisteroData]
      ,[MotivazioneResponsabileMinistero]
      ,[Comunicazione]
      ,[ComunicazioneData]
---UPDATE  [TEST_RRN25-27].[dbo].[Output] SET Comunicazione=1
WHERE
 CodOutputCompleto IN
  (
 'IS01.01_ASC_03'
,'IS01.02_ASC_01'
,'IS01.06_ASC_01'
,'IS01.06_ASC_02'
,'IS01.07_STV_01'
,'IS01.07_WFG_02'
,'IS01.09_ASC_01'
,'IS02.01_ASC_01'
,'IS02.03_ASC_02'
,'IS03.02_ASC_01'
,'IS03.02_POL_03'
,'IS03.02_SRE_05'
,'IS03.02_ASC_06'
,'IS03.02_SRE_09'
,'IS05.03_ASC_01'
,'IS05.03_PHC_02'
,'IS05.04_ASC_01'
,'IS05.04_PHC_02'
,'IS05.05_ASC_01'
,'IS05.06_ASC_01'
,'IS05.06_PHC_02'
,'IS06.01_ASC_01'
,'IS06.02_ASC_01'
,'IS07.01_CSV_01'
,'IS07.01_CSV_02'
,'IS07.01_ASC_06'
,'IS07.01_ASC_07'
,'IS07.01_WFG_08'
,'IS07.01_MPP_09'
,'IS07.01_WFG_10'
,'IS07.01_MPP_11'
,'IS07.01_MPP_12'
,'IS07.01_PHC_13'
,'IS07.01_PHC_14'
,'IS07.01_CSV_15'
,'IS07.01_MPP_16'
,'IS07.01_PHC_17'
,'IS07.01_PHC_18'
,'IS07.01_CSV_19'
,'IS07.01_MPP_20'
,'IS07.01_PHC_21'
,'IS07.01_PHC_22'
,'IS07.01_PHC_23'
,'IS07.01_CSV_24'
,'IS07.01_PHC_25'
,'IS07.01_PHC_26'
,'IS07.01_PHC_27'
,'IS07.01_STV_28'
,'IS07.01_WFG_29'
,'IS07.01_WFG_30'
,'IS07.01_CSV_31'
,'IS07.01_POL_32'
,'IS07.01_ASC_33'
,'IS07.01_ASC_34'

)

  SELECT OutputProgrammato,* FROM Output WHERE CodOutputCompleto like ('IS02.03_ASC_02%')
---UPDATE Output SET OutputProgrammato='in collaborazione con la scheda Azioni di comunicazione IS.07, supporto per: la realizzazione di almeno 2 mappe on line/PDF, e la versione inglese; il miglioramento di 19 mappe esistenti on line, che include la descrizione di ulteriori elementi di attrazione storici, culturali e ambientali, e la  versione inglese;  l’aggiornamento continuativo della brochure dei paesaggi; la realizzazione di una campagna di comunicazione sui paesaggi rurali e strumenti dello sviluppo rurale per la loro valorizzazione' WHERE CodOutputCompleto like ('IS02.03_ASC_02%')


SELECT TOP (1000) [IdOutput]
      ,[IdProgetto]
      ,[UltimoAggiornamento]
      ,[CodPriorita]
      ,[ObiettivoRete]
      ,[RisultatiAttesi]
      ,[CodTema]
      ,[CodTipoOutput]
      ,[CodOutputCompleto]
      ,[OutputDescrizione]
      ,[OutputProgrammato]
      ,[OutputRealizzato]
      ,[OutputNonProgrammato]
      ,[NumOutputProgrammato]
      ,[NumOutputRealizzato]
      ,[NumOutputNonProgrammato]
      ,[OutputAllegato]
      ,[OutputLink]
      ,[NoteOutputResponsabileEnte]
      ,[ParereResponsabileMinistero]
      ,[ParereResponsabileMinisteroData]
      ,[MotivazioneResponsabileMinistero]
      ,[Comunicazione]
      ,[ComunicazioneData]
---UPDATE [TEST_RRN25-27].[dbo].[Output] SET OutputDescrizione='Progetto ad hoc'
  FROM [TEST_RRN25-27].[dbo].[Output]
  WHERE [CodOutputCompleto] IN
  ('IS05.02_PHC_03'
,'IS05.02_PHC_05'
,'IS05.03_PHC_02')
