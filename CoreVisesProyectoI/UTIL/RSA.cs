using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UTIL{
    public class RSA{
        //Attributes
        private string privateKey;
        private string publicKey;

        public RSA(){
            this.privateKey = "<xml><BitStrength>512</BitStrength><RSAKeyValue><Modulus>8XotGiYuczvsRjVCtCKAf7DJ9IWFo6dzGAKnrXtvRxT5LwAHxxWGAdfsvl5pWCLxS9VUjR/FaneMAoGMH1gP9w==</Modulus><Exponent>AQAB</Exponent><P>/pEhmXDo/dWNYpTwNSLdeNiqF9CFORddKmnVrMfndjM=</P><Q>8tYuR1VeQ5pGVqrApmcoA0YlXVCr+8zpeHRiJn8Tky0=</Q><DP>GoyiV3FqK0cBZt2nq7MGLBtUqgUqT8j7A3hkO4/huPc=</DP><DQ>3pGGGyVYX3ewDlE0f4++sbmCF5QP/ZqjRh7NsuD37QU=</DQ><InverseQ>wd4u6p6Xbjm5k9qbxjuTdbiaQNz7Cz+1X2oYvJPtal4=</InverseQ><D>c4yDCIA8uedyqCXURV49Htz5xogd6rG14Udj9R+bn+b7UhJ4l2ocZcKc4YEq2fY+m8yznHILtiqxZSvhx6a8AQ==</D></RSAKeyValue></xml>";
            this.publicKey = "<RSAKeyValue><Modulus>8XotGiYuczvsRjVCtCKAf7DJ9IWFo6dzGAKnrXtvRxT5LwAHxxWGAdfsvl5pWCLxS9VUjR/FaneMAoGMH1gP9w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        }//End costruct default

        public byte[] EncryptText(string text, string xmlPublic){
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPublic);
            byte[] encryptedData = RSA.Encrypt(Encoding.ASCII.GetBytes(text), true);
            return encryptedData;
        }//End EncryptText

        public byte[] DecryptText(string encryptedText, string xmlPrivate){
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);
            RSA.FromXmlString(xmlPrivate);
            byte[] decryptData = RSA.Decrypt(Convert.FromBase64String(encryptedText), true);
            return decryptData;
        }//End DecryptText

        public string PrivateKey{
            get{
                return this.privateKey;
            }//End get
            set {
                this.privateKey = value;
            }//End set
        }//End PrivateKey

        public string PublicKey{
            get{
                return this.publicKey;
            }//End get
            set{
                this.publicKey = value;
            }//End set
        }//End PublicKey

    }//End class RSA

}//End namespace UTIL
