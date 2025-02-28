## Instruções para o teste da api
- Modificar os arquivos appsettings dentro dos projetos: Ambev.DeveloperEvaluation.ORM e Ambev.DeveloperEvaluation.WebApi.
- Estes arquivos deverão ter a string de conexão modificadas para um banco Postgre que será criado para os testes.
- Executar o migration no projeto Ambev.DeveloperEvaluation.ORM.
- Agora só executar o projeto da WebApi!

**Como não fiz uma interface os testes precisarão serem feitos com os Ids que eu deixei pre cadastrados no banco.**

**Branch**
ea30833e-4a57-44c3-9604-731196b407f2	Branch 1
56af56f2-a6bd-430d-b292-53a8f0cb7f71	Branch 2

**Product**
0d2aab37-6a72-4c20-9795-eee98c3c5c71	Product 1
6b01861f-a189-4bad-93be-d9bb58bf7f12	Product 2

**Customer**
64a285a4-c3ae-4e99-b442-d1c042587334	Customer 1
7204c72f-c77b-42e9-aae1-081fa0364b3a	Customer 2

**Exemplo de json para inserir uma venda**
{
  "customerId": "7204c72f-c77b-42e9-aae1-081fa0364b3a",
  "branchId": "56af56f2-a6bd-430d-b292-53a8f0cb7f71",
  "products": [
    {
      "productId": "0d2aab37-6a72-4c20-9795-eee98c3c5c71",
      "quantity": 1
    },
	{
      "productId": "6b01861f-a189-4bad-93be-d9bb58bf7f12",
      "quantity": 4
    }
  ]
}