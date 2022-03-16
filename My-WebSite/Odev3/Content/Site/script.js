/* üye kayıt kontrolleri */

function kontrol(){
    var eposta=document.getElementById("eposta").value;
    var kullaniciadi=document.getElementById("kullaniciadi").value;
    var sifre1=document.getElementById("sifre1").value;
    var sifre2=document.getElementById("sifre2").value;

    if(kullaniciadi.length<6){
        alert("Kullanıcı adı 6 karakterden kısa olamaz.");    
    }
    
    else if(sifre1.length<5){
        alert("Şifre 6 karakterden kısa olamaz.");    
    }

    var simge=eposta.indexOf("@");
    if(simge==-1){
        alert("E-mail adresinde '@' karakteri bulunmalıdır.")
    }

    else if(sifre1!=sifre2){
        alert("Girdiğiniz şifreler uyuşmamaktadır. Şifrenizi tekrar giriniz.");

    }
    else{
        alert("Kaydınız başarıyla tamamlandı!");
    }
}