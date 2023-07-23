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
        //Translate: Objemizi transform componentini kullanarak ad�m ad�m hareket ettirmemizi sa�lar.
        //Local veya global sistemi kullanmam�za olanak sa�lar.

        //Vector3'de de�er verebilece�imiz 6 tane y�n�m�z bulunmakta bunlar; Forward,Right,Left,Back,Down ve Up.
        //Time.deltaTime kullanarak 1 birim/saniye olarak ilerletebiliriz.
        //Space.World kullanarak uzay h�z�nda 1 birim/saniye olarak ilerletebiliriz.
        transform.Translate(Vector3.forward * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        //Translate i�in yazd���m�z Vector3 bilgisini klavye tu�lar�m�zla hareket ettirmek i�in de�i�ken olu�turabiliriz.
        // �rnek:
        float hzInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * hzInput * Time.deltaTime);
        //Ya da de�i�ken olarak tan�mlad���m�z her hangi de�i�keni "�r:Speed" vector3 pozisyonumuza ekleyerek otomatik olarak gitmesini sa�layabiliriz.
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        //Rotate: Vector3 cinsinden rotasyon de�erini de�i�tirmemizi sa�lar.
        //Local veya global sistemi kullanmam�za olanak sa�lar.

        // transform.rotate yazd�ktan sonra s�ras�yla X,Y,Z de�erleri vererek istedi�imiz y�nde rotation i�lemi uygulayabiliriz.
        // �rnek:
        transform.Rotate(0, 0, 0);
        //Translate gibi de�i�kenler tan�mlayarak eksenlerimizdeki hareketleri otomatik ya da manuel olarak yapabiliriz.
        transform.Rotate(0, 0, 0 * Time.deltaTime);
        transform.Rotate(0, 0, 0,Space.World);

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        //Rigidbody componentinin Addforce �zelli�ini kullanarak �e�itli mekanikler oyunumuza sa�layabiliriz.
        //�rnek:

        //Rigidbody rb; tan�mlad�ktan sonra
        
        rb.AddForce(Vector3.up * speed*Time.deltaTime);
        //Tan�mlad���m�z speed de�i�keniyle Vector3 y�nlerimizden birini kullanarak yukar�ya do�ru hareket sa�l�yoruz.

        //AddForce �zelli�i ile hareket sa�layabilmek gibi farkl� mekanikler de olu�turabiliriz.�rnek olarak aniden bir y�ne do�ru karakterimize-
        // g�� vermemiz gerekti�inde Vector3 y�nlerimizden birisini se�erek bu mekani�i olu�turabiliriz.
        //AddForce �zelli�imiz de ForceMode kullanarak kuvvetin nas�l uygulanaca��n� belirleyebiliriz.
        //Bunlar Acceleration,Force,Impulse ve VelocityChange'dir.


    }
}
