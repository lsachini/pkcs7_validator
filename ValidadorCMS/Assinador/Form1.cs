using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using System.IO;
using System.Data.Odbc;
using System.Security.Cryptography;

namespace Assinador
{
    public partial class frmAssinador : Form
    {
        public frmAssinador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] certificado = File.ReadAllBytes(@"z:\Users\leandro_2\Documents\Publica\pki\certificados\cadeia4.p12");
            //byte[] certificado1 = File.ReadAllBytes(@"c:\Users\leandro_2\Documents\Publica\pki\certificados\cadeia11.p12");

            X509Certificate2 cert = new X509Certificate2(certificado, "teste");
            //X509Certificate2 aut = new X509Certificate2(autoridade);

            SignedCms cms = new SignedCms(new ContentInfo(new byte[] { 1, 2, 3, 4, 5 }), true);

            CmsSigner signer = new CmsSigner(cert);

            String agora = DateTime.Now.ToUniversalTime().ToString("yyMMddHHmmss");
            Byte[] data = Encoding.ASCII.GetBytes(agora);

            byte[] codificado = new Byte[data.Length + 3];

            codificado[0] = 0x17;
            codificado[1] = 0x0D;
            Array.Copy(data, 0, codificado, 2, data.Length);
            codificado[codificado.Length - 1] = (Byte)'Z';

            Oid oid = new Oid("1.2.840.113549.1.9.5");

            AsnEncodedData asn = new AsnEncodedData( oid, codificado  );
     
            signer.SignedAttributes.Add(asn);
            signer.IncludeOption = X509IncludeOption.EndCertOnly;

            cms.ComputeSignature(signer);

            X509Certificate2 cert1 = new X509Certificate2(certificado, "teste");
            //X509Certificate2 aut = new X509Certificate2(autoridade);

            //CmsSigner signer1 = new CmsSigner(cert);

            //AsnEncodedData asn1 = new AsnEncodedData(oid, codificado);

            //signer1.SignedAttributes.Add(asn1);
            //signer1.IncludeOption = X509IncludeOption.EndCertOnly;

            //cms.ComputeSignature(signer);
            
            byte[] assinatura = cms.Encode();

            Validador.ValidadorCMS validador = new Validador.ValidadorCMS();

            //String ass = "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";

            String retorno = validador.ValidarCMS(Convert.ToBase64String(new byte[] { 1, 2, 3, 4, 5 }),
                                                  Convert.ToBase64String(assinatura),
                                                  "Regra03");
            MessageBox.Show(retorno);
        }

        private void frmAssinador_Load(object sender, EventArgs e)
        {

        }
    }
}
