Feature: Wikipedia

Scenario: valide title Google
	Given que naveguei para a página "https://www.wikipedia.org/" da Wikipedia 
	Then o título da página deve conter "Google - Wikipedia"
