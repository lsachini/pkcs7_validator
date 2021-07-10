# pkcs7_validator
This project presents the implementation of a system for validation of electronic signatures (encoded in the
“Cryptographic Message Syntax” format), that incorporates the concept of contextual validation determined by
each specific use domain. A solution was developed that allows the construction of rules, which are applied during
the verification of the validity of an electronic signature. These rules allow the construction of logical expressions
from elements that must be present in certificates of the trust chain for a specific utilization context. This approach
solves the problem found in many validation solutions, which in some cases are very generic, successfully returning
any certificate chain recognized as trusted for the complete system, whereas in other cases they are very specific,
working only on specific certificate chains.


Este projeto apresenta a implementação de um sistema de validação de assinaturas eletrônicas (codificadas no
formato chamado Cryptographic Message Syntax) que incorpora o conceito de validação de acordo com o contexto
de utilização. Para possibilitar esse tipo de validação, foi desenvolvida uma solução que permite a construção de
regras, que são aplicadas durante a verificação da validade de uma assinatura eletrônica. Essas regras permitem a
construção de expressões lógicas, a partir de elementos que devem estar presentes na cadeia de confiança de
certificados em um contexto de utilização específico. Essa abordagem resolve o problema encontrado em algumas
soluções de validação, que em alguns casos são muito genéricas, retornando como válidas qualquer cadeia de
certificados reconhecidas como confiável pelo sistema, e em outros muito específicas, atuando apenas sobre
certificados de cadeias específicas. 
