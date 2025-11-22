INSERT INTO [UtentiProgettoMinistero] (idProgetto,idUtente) VALUES (1,(SELECT idUtente FROM Utenti WHERE Utente ='Paolo Ammassari'))
INSERT INTO [UtentiProgettoMinistero] (idProgetto,idUtente) VALUES (4,(SELECT idUtente FROM Utenti WHERE Utente ='Paolo Ammassari'))
INSERT INTO [UtentiProgettoMinistero] (idProgetto,idUtente) VALUES (6,(SELECT idUtente FROM Utenti WHERE Utente ='Paolo Ammassari'))


INSERT INTO [UtentiProgettoMinistero] (idProgetto,idUtente) VALUES (7,(SELECT idUtente FROM Utenti WHERE Utente like 'Carmela Macr%'))
INSERT INTO [UtentiProgettoMinistero] (idProgetto,idUtente) VALUES (1,(SELECT idUtente FROM Utenti WHERE Utente like 'Laura Panico%' AND Email='laura.panicoRM@masaf.gov.it'))