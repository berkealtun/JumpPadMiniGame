using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;
    void Start()
    {
        
    }
    
    void Update()
    {
        //Translate: Objemizi transform componentini kullanarak adým adým hareket ettirmemizi saðlar.
        //Local veya global sistemi kullanmamýza olanak saðlar.

        //Vector3'de deðer verebileceðimiz 6 tane yönümüz bulunmakta bunlar; Forward,Right,Left,Back,Down ve Up.
        //Time.deltaTime kullanarak 1 birim/saniye olarak ilerletebiliriz.
        //Space.World kullanarak uzay hýzýnda 1 birim/saniye olarak ilerletebiliriz.
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        //Translate için yazdýðýmýz Vector3 bilgisini klavye tuþlarýmýzla hareket ettirmek için deðiþken oluþturabiliriz.
        // Örnek:
        float hzInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * hzInput * Time.deltaTime);
        //Ya da deðiþken olarak tanýmladýðýmýz her hangi deðiþkeni "Ör:Speed" vector3 pozisyonumuza ekleyerek otomatik olarak gitmesini saðlayabiliriz.
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        //Rotate: Vector3 cinsinden rotasyon deðerini deðiþtirmemizi saðlar.
        //Local veya global sistemi kullanmamýza olanak saðlar.

        // transform.rotate yazdýktan sonra sýrasýyla X,Y,Z deðerleri vererek istediðimiz yönde rotation iþlemi uygulayabiliriz.
        // Örnek:
        transform.Rotate(0, 0, 0);
        //Translate gibi deðiþkenler tanýmlayarak eksenlerimizdeki hareketleri otomatik ya da manuel olarak yapabiliriz.
        transform.Rotate(0, 0, 0 * Time.deltaTime);
        transform.Rotate(0, 0, 0,Space.World);

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        //Rigidbody componentinin Addforce özelliðini kullanarak çeþitli mekanikler oyunumuza saðlayabiliriz.
        //Örnek:

        //Rigidbody rb; tanýmladýktan sonra
        
        rb.AddForce(Vector3.up * speed*Time.deltaTime);
        //Tanýmladýðýmýz speed deðiþkeniyle Vector3 yönlerimizden birini kullanarak yukarýya doðru hareket saðlýyoruz.

        //AddForce özelliði ile hareket saðlayabilmek gibi farklý mekanikler de oluþturabiliriz.Örnek olarak aniden bir yöne doðru karakterimize-
        // güç vermemiz gerektiðinde Vector3 yönlerimizden birisini seçerek bu mekaniði oluþturabiliriz.
        //AddForce özelliðimiz de ForceMode kullanarak kuvvetin nasýl uygulanacaðýný belirleyebiliriz.
        //Bunlar Acceleration,Force,Impulse ve VelocityChange'dir.


    }
}
