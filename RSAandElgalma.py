from math import pow
from tkinter import *
from tkinter import filedialog
import hashlib
import random
from tkinter import messagebox


win = Tk()
win.title("Các hệ mật bất đối xứng")
win.iconbitmap('')
win.geometry("600x400")
C= Canvas(win,bg = "gray16" , height=200,width=200)
filename = PhotoImage(file="")
background_label = Label(win, image=filename)
background_label.place(x=0, y=0, relwidth=1, relheight=1)

# hàm thực hiện chức năng chính
def mainPage() :  

    def RSAButton() :
        background_label.destroy()
        lbl.destroy()
        btnRSA.destroy()
        btnElgalma.destroy()

        # Ham mat ma hoa
        def btnBack1() : 
            lbtk.destroy()
            lb2.destroy()
            lb3.destroy()
            lb4.destroy()
            lb5.destroy()
            lb6.destroy()
            lb7.destroy()
            lb8.destroy()  
            lb9.destroy()
            lb10.destroy()
            lb11.destroy()
            lb12.destroy()
            lb13.destroy()
            lb14.destroy()
            lb15.destroy()
            lb16.destroy()
            lb17.destroy()
            lb18.destroy()
            lb19.destroy()
            lb20.destroy()
            pT_ent.destroy()
            btn3.destroy()
            pEnt.destroy()
            qEnt.destroy()
            btn1.destroy()
            btn2.destroy()
            
            mainPage()
        # Tìm UCLN

        def gcd(a, b):
            if(b == 0):
                return a
            return gcd(b, a % b)

        # Ham doi he co so 10 ve co so 2


        def dec2bin(s):
            # print(s)
            sb = ""
            while (s > 0):
                sb += str(s % 2)
                s = s // 2
            return "".join(reversed(sb))

        # Ham tinh nghich dao nhan


        def multiple_inverse(a, b):
            m, n = a, b
            xm, ym = 1, 0
            xn, yn = 0, 1
            while (n != 0):
                q = m // n  # chia lấy phần nguyên
                r = m % n  # chia lấy phần dư
                xr, yr = xm - q*xn, ym - q*yn
                m = n
                xm, ym = xn, yn
                n = r
                xn, yn = xr, yr
            return xm % b


        # Ham thuat toan binh phuong va nhan
        def power_modulo(x, n, m):
            p = 1
            H = dec2bin(n)
            for i in range(len(H)):
                p = (p*p) % m
                if (H[i] == '1'):
                    p = (p*x) % m
            return p

        # Ham mat ma hoa


        def encrypt(M, e, n):

            C = power_modulo(M, e, n)
            return C


        def decrypt(C, d, n):
            RP = power_modulo(C, d, n)
            return RP


        def creat_key(phi_n):
            # e = 11
            e = random.randint(2,phi_n)
            while(gcd(phi_n,e) != 1) :
                    e = random.randint(1,phi_n)
            d = multiple_inverse(e, phi_n)
            key_private = d
            key_public = e
            return key_public, key_private

        def hienthi2():
            q = int(qEnt.get())
            p = int(pEnt.get())
            n = q*p
            phi_n = (p-1)*(q-1)
            public_Key, private_Key = creat_key(phi_n)

            lb7 = Label(win, text='n = ', font='Times 10 bold')
            lb7.grid(row=5, column=1)
            lb8 = Label(win, text=n, font='Times 10 bold')
            lb8.grid(row=5, column=2)
            lb9 = Label(win, text='phi_n = ', font='Times 10 bold')
            lb9.grid(row=6, column=1)
            lb10 = Label(win, text=phi_n, font='Times 10 bold')
            lb10.grid(row=6, column=2)

            lb11 = Label(win, text='e = ', font='Times 10 bold')
            lb11.grid(row=7, column=1)
            lb12 = Label(win, text=public_Key, font='Times 10 bold')
            lb12.grid(row=7, column=2)

            lb13 = Label(win, text='d = ', font='Times 10 bold')
            lb13.grid(row=8, column=1)
            lb14 = Label(win, text=private_Key, font='Times 10 bold')
            lb14.grid(row=8, column=2)


        def hienthi3():
            q = int(qEnt.get())
            p = int(pEnt.get())

            n = q*p
            phi_n = (p-1)*(q-1)
            pT_ent.insert
            plain_text = pT_ent.get()
            print(phi_n)
            cipher_text = ''
            cipher_text1 = []
            key_pv = []
            for i in range(len(plain_text)):
                N = ord(plain_text[i])
                public_Key, private_Key = creat_key(phi_n)
                C = encrypt(N, public_Key, n)
                key_pv.append(private_Key)
                cipher_text1.append(chr(C))
                cipher_text += chr(C)
                print(C)

            Label(win, text=cipher_text, font='Times 10 bold').grid(row=14, column=2)


        def hienthi4():
            q = int(qEnt.get())
            p = int(pEnt.get())
            n = q*p
            phi_n = (p-1)*(q-1)
            plain_text = pT_ent.get()
            print(plain_text)
            cipher_text = ''
            cipher_text1 = []
            #key_pv = []
            public_Key, private_Key = creat_key(phi_n)

            for i in range(len(plain_text)):
                N = ord(plain_text[i])
                C = encrypt(N, public_Key, n)
                # key_pv.append(private_Key)
                cipher_text1.append(chr(C))
                cipher_text += chr(C)
            #k = 0
            recover_text = ''
            for u in cipher_text1:
                u = ord(u)
                #private_Key = key_pv[k]
                R = chr(decrypt(u, private_Key, n))
                recover_text += R
                #k += 1
            Label(win, text=recover_text, font='Times 10 bold').grid(row=16, column=2)

        # hệ mật RSA

        # lbl = Label(win , text="Xin chào, mời bạn chọn hệ mật", fg = "green" , font=("Times New Roman" , 32) , width= 25 , relief="groove" 
        lb2 = Label(win, text='Hệ mật mã RSA', font=('Times 10 bold') , width= 25 , relief="groove")
        lb2.grid(row=1, column=0)
        lbtk =  Label(win, text='Tạo khóa', font=('Times 10 bold'))
        lbtk.grid(row=2, column=0)
        lb3 = Label(win, text='p = ', font='Times 14 bold')
        lb3.grid(row=3, column=1)
        
        pEnt = Entry(win, font='Times 10 bold')
        pEnt.grid(row=3, column=2)

        lb4 = Label(win, text='q = ', font='Times 14 bold')
        lb4.grid(row=4, column=1)
        qEnt = Entry(win, font='Times 10 bold')
        qEnt.grid(row=4, column=2)
        btn1 = Button(win, text='Tạo', font='Times 10 bold', command=hienthi2)
        btn1.grid(row=5, column=0)


        
        lb20 = Label(win, text='-------------------------')
        lb20.grid(row=9)


        btn2 = Button(win, text='Mã hóa', font='Times 10 bold', command=hienthi3)
        btn2.grid(row=11, column=0)

        Label(win, text='Bản rõ: ', font='Times 10 bold').grid(row=11, column=1)

        pT_ent = Entry(win, font='Times 10 bold')
        pT_ent.grid(row=11, column=2)

        btn3 = Button(win, text='Giải mã', font='Times 10 bold', command=hienthi4)
        btn3.grid(row=16, column=0)

        lb5 = Label(win, text='Bãn mã hóa', font='Times 10 bold')
        lb5.grid(row=12, column=1)
        lb6 = Label(win, text='Bãn rõ', font='Times 10 bold')
        lb6.grid(row=16, column=1)
        btnBack11 = Button(win , text='Trở lại',font  ='Times 10 bold',command=btnBack1)
        btnBack11.grid(row=17 , column= 3 )
        lb7 = Label(win, text='n = ', font='Times 10 bold')
        lb7.grid(row=5, column=1)
        lb8 = Label(win, text='', font='Times 10 bold')
        lb8.grid(row=5, column=2)
        lb9 = Label(win, text='phi_n = ', font='Times 10 bold')
        lb9.grid(row=6, column=1)
        lb10 = Label(win, text='', font='Times 10 bold')
        lb10.grid(row=6, column=1)

        lb11 = Label(win, text='e = ', font='Times 10 bold')
        lb11.grid(row=7, column=1)
        lb12 = Label(win, text='', font='Times 10 bold')
        lb12.grid(row=7, column=2)

        lb13 = Label(win, text='d = ', font='Times 10 bold')
        lb13.grid(row=8, column=1)
        lb14 = Label(win, text='', font='Times 10 bold')
        lb14.grid(row=8, column=2)
        


    def RabinButton() : 
        lbl.destroy()
        btnRSA.destroy()
        btnElgalma.destroy()
        
    def ElgalmaButton() : 
        lbl.destroy()
        btnRSA.destroy()
        btnElgalma.destroy()
        
                # Hệ mã elgamal

        a = random.randint(2, 10)

        # hàm tìm UCLN của 2 số 
        def gcd(a,b):
            if a<b:
                return gcd(b,a)
            elif a%b==0:
                return b
            else:
             return gcd(b,a%b)
        # Hàm tạo khóa hệ mật elgalma
        def gen_key(q):

            key = random.randint(pow(10, 2), q)
            while gcd(q, key) != 1:
                key = random.randint(pow(10, 2), q)

            return key

        # Modular exponentiation

        def power(a, b, c):
            x = 1
            y = a

            while b > 0:
                if b % 2 == 0:
                    x = (x * y) % c
                y = (y * y) % c
                b = int(b / 2)

            return x % c

        # Hàm mã hóa hệ mật ElGalma


        def encrypt1(msg, q, h, g):

            en_msg = []

            k = gen_key(q)  # Private key for sender
            s = power(h, k, q)
            p = power(g, k, q)

            for i in range(0, len(msg)):
                en_msg.append(msg[i])

            print("g^k used : ", p)
            print("g^ak used : ", s)
            for i in range(0, len(en_msg)):
                en_msg[i] = s * ord(en_msg[i])

            return en_msg, p

        # Hàm giải mã ElGalma
        def decrypt1(en_msg, p, key, q):

            dr_msg = []
            h = power(p, key, q)
            for i in range(0, len(en_msg)):
                dr_msg.append(chr(int(en_msg[i]/h)))

            return dr_msg


        def hienthi5():
            q = int(q1_ent.get())
            g = random.randint(2, q)
            key = gen_key(q)
            d = power(g, key, q)
            g_ent.insert(0, g)

            a_ent.insert(0, key)
            d_ent.insert(0, d)


        def hienthi6():
            q = int(q1_ent.get())
            g = random.randint(2, q)
            key = gen_key(q)
            d = power(g, key, q)
            msg = pT1_ent.get()
            ct, p = encrypt1(msg, q, d, g)
            cP1_ent.insert(0, ct)


        def hienthi7():
            q = int(q1_ent.get())
            g = random.randint(2, q)
            key = gen_key(q)
            d = power(g, key, q)
            msg = pT1_ent.get()
            ct, p = encrypt1(msg, q, d, g)
            pt = decrypt1(ct, p, key, q)
            d_msg = ''.join(pt)
            pT2_ent.insert(0, d_msg)


        Label(win, text='Hệ mật mã Elgamal', font=(
            'Times 10 bold')).grid(row=1, column=6)
        Label(win, text='public key (p, g, A)', font=(
            'Times 10 bold')).grid(row=2, column=6)
        Label(win, text='Số nguyên tố:  p = ', font=(
            'Times 10 bold')).grid(row=3, column=7)
        q1_ent = Entry(win, font=('Times 10 bold'))
        q1_ent.grid(row=3, column=8)
        Label(win, text='Số alpha:  g = ', font=(
            'Times 10 bold')).grid(row=4, column=7)
        g_ent = Entry(win, font=('Times 10 bold'))
        g_ent.grid(row=4, column=8)
        Label(win, text='(d = g^x mod p): Số d = ',
            font=('Times 10 bold')).grid(row=5, column=7)
        d_ent = Entry(win, font=('Times 10 bold'))
        d_ent.grid(row=5, column=8)
        Label(win, text='private key(a)', font=(
            'Times 10 bold')).grid(row=6, column=6)
        Label(win, text='Số nguyên a = ', font=(
            'Times 10 bold')).grid(row=7, column=7)
        a_ent = Entry(win, font=('Times 10 bold'))
        a_ent.grid(row=7, column=8)
        btn3 = Button(win, text='Tạo khóa tùy chon',
                    font='Times 10 bold', command=hienthi5)
        btn3.grid(row=8, column=6)
        Label(win, text='Bản rõ ', font=('Times 10 bold')).grid(row=9, column=7)
        pT1_ent = Entry(win, font=('Times 10 bold'))
        pT1_ent.grid(row=9, column=8)
        btn4 = Button(win, text='Mã hóa', font='Times 10 bold', command=hienthi6)
        btn4.grid(row=10, column=6)
        Label(win, text='Bản giải mã ', font=('Times 10 bold')).grid(row=11, column=7)
        cP1_ent = Entry(win, font=('Times 10 bold'))
        cP1_ent.grid(row=11, column=8)
        btn5 = Button(win, text='Giải mã ', font='Times 10 bold', command=hienthi7)
        btn5.grid(row=12, column=6)
        Label(win, text='Bản rõ ', font=('Times 10 bold')).grid(row=13, column=7)
        pT2_ent = Entry(win, font=('Times 10 bold'))
        pT2_ent.grid(row=13, column=8)
    
    lbl = Label(win , text="Xin chào, mời bạn chọn hệ mật", fg = "green" , font=("Times New Roman" , 32) , width= 25 , relief="groove" )
    lbl.grid(column=0 , row = 0)
    
    btnRSA = Button(win,text = "Hệ mật RSA" ,font='Times 20 bold' ,  command=RSAButton)
    btnRSA.grid(row=1,column=0)

    lb15 = Label(win, text='')
    lb15.grid(row=2, column=0)
    lb16 = Label(win, text='')
    lb16.grid(row=3, column=0)
    lb17 = Label(win, text='')
    lb17.grid(row=4, column=0)
    lb18 = Label(win, text='')
    lb18.grid(row=5, column=0)
    lb19 = Label(win, text='')
    lb19.grid(row=6, column=0)

    
    btnElgalma = Button(win,text = "Hệ mật ElGalma" ,font='Times 20 bold', command=ElgalmaButton)
    btnElgalma.grid(row=7,column=0)

mainPage()


win.mainloop()

