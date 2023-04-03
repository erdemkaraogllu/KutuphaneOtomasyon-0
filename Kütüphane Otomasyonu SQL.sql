PGDMP                         {            Kutuphane_Otomasyonu    15.0    15.0 >    ;           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            <           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            =           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            >           1262    16792    Kutuphane_Otomasyonu    DATABASE     �   CREATE DATABASE "Kutuphane_Otomasyonu" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
 &   DROP DATABASE "Kutuphane_Otomasyonu";
                postgres    false            �            1255    17019 7   arsiv_kitap_islem(character varying, character varying)    FUNCTION     7  CREATE FUNCTION public.arsiv_kitap_islem(_yonetici character varying, _kitap_islem character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into arsiv(yonetici,kitap_islem)
	values(_yonetici, _kitap_islem);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 e   DROP FUNCTION public.arsiv_kitap_islem(_yonetici character varying, _kitap_islem character varying);
       public          postgres    false            �            1255    17018 5   arsiv_uye_islem(character varying, character varying)    FUNCTION     /  CREATE FUNCTION public.arsiv_uye_islem(_yonetici character varying, _uye_islem character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into arsiv(yonetici,uye_islem)
	values(_yonetici, _uye_islem);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 a   DROP FUNCTION public.arsiv_uye_islem(_yonetici character varying, _uye_islem character varying);
       public          postgres    false            �            1255    17013 -   arsivle(character varying, character varying)    FUNCTION       CREATE FUNCTION public.arsivle(_yonetici character varying, _islem character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into arsiv(yonetici,islem)
	values(_yonetici, _islem);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 U   DROP FUNCTION public.arsivle(_yonetici character varying, _islem character varying);
       public          postgres    false            �            1255    16908 /   emanet_al(character varying, character varying)    FUNCTION     >  CREATE FUNCTION public.emanet_al(_tc character varying, _kitap_ad character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
                        begin
                            insert into emanet_kitap(tc,kitap_ad,emanet_date,teslim_date)
                            values(_tc, _kitap_ad, CURRENT_DATE, CURRENT_DATE+3);
                            if found then --Başarılı
                                return 1;
                            else return 0; --Hata
                            end if;
                        end
                        $$;
 T   DROP FUNCTION public.emanet_al(_tc character varying, _kitap_ad character varying);
       public          postgres    false            �            1255    16960 5   emanet_al(character varying, character varying, date)    FUNCTION     _  CREATE FUNCTION public.emanet_al(_tc character varying, _kitap_ad character varying, _teslim_date date) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into emanet_kitap(tc,kitap_ad,emanet_date,teslim_date)
	values(_tc,_kitap_ad,CURRENT_DATE,_teslim_date);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 g   DROP FUNCTION public.emanet_al(_tc character varying, _kitap_ad character varying, _teslim_date date);
       public          postgres    false            �            1255    16899 ~   kitap_insert(character varying, character varying, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.kitap_insert(_kitap_ad character varying, _yazar character varying, _tur character varying, _yayin_evi character varying, _basim character varying, _sayfa character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into kitap(kitap_ad, yazar, tur, yayin_evi, basim, sayfa)
	values(_kitap_ad, _yazar, _tur, _yayin_evi, _basim, _sayfa);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 �   DROP FUNCTION public.kitap_insert(_kitap_ad character varying, _yazar character varying, _tur character varying, _yayin_evi character varying, _basim character varying, _sayfa character varying);
       public          postgres    false            �            1255    16921 2   kitap_okundu(character varying, character varying)    FUNCTION       CREATE FUNCTION public.kitap_okundu(_tc character varying, _kitap_ad character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into okunan_kitap(tc,kitap_ad)
	values(_tc,_kitap_ad);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 W   DROP FUNCTION public.kitap_okundu(_tc character varying, _kitap_ad character varying);
       public          postgres    false            �            1255    17062 �   kitap_update(integer, character varying, character varying, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.kitap_update(_kitap_id integer, _kitap_ad character varying, _yazar character varying, _tur character varying, _yayin_evi character varying, _basim character varying, _sayfa character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	update kitap
	set	
		kitap_ad = _kitap_ad,
		yazar = _yazar,
		tur = _tur,
		yayin_evi = _yayin_evi,
		basim = _basim,
		sayfa = _sayfa
	where kitap_id = _kitap_id;
	if found then 
		return 1;
	else 
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.kitap_update(_kitap_id integer, _kitap_ad character varying, _yazar character varying, _tur character varying, _yayin_evi character varying, _basim character varying, _sayfa character varying);
       public          postgres    false            �            1255    17061 �   kitap_update(character varying, character varying, character varying, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.kitap_update(_kitap_id character varying, _kitap_ad character varying, _yazar character varying, _tur character varying, _yayin_evi character varying, _basim character varying, _sayfa character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	update kitap
	set	
		kitap_ad = _kitap_ad,
		yazar = _yazar,
		tur = _tur,
		yayin_evi = _yayin_evi,
		basim = _basim,
		sayfa = _sayfa
	where kitap_id = _kitap_id;
	if found then 
		return 1;
	else 
		return 0;
	end if;
end
$$;
 �   DROP FUNCTION public.kitap_update(_kitap_id character varying, _kitap_ad character varying, _yazar character varying, _tur character varying, _yayin_evi character varying, _basim character varying, _sayfa character varying);
       public          postgres    false            �            1255    17037 0   llog_kitap(character varying, character varying)    FUNCTION     S  CREATE FUNCTION public.llog_kitap(_username character varying, _log_kitap character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into log_yonetici(username, log_kitap, log_uye, zaman)
	values(_username, _log_kitap,'-',current_date);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 \   DROP FUNCTION public.llog_kitap(_username character varying, _log_kitap character varying);
       public          postgres    false            �            1255    17036 1   llog_kitapp(character varying, character varying)    FUNCTION     T  CREATE FUNCTION public.llog_kitapp(_username character varying, _log_kitap character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into log_yonetici(username, log_kitap, log_uye, zaman)
	values(_username, _log_kitap,'-',current_date);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 ]   DROP FUNCTION public.llog_kitapp(_username character varying, _log_kitap character varying);
       public          postgres    false            �            1255    17045 .   llog_uye(character varying, character varying)    FUNCTION     O  CREATE FUNCTION public.llog_uye(_username character varying, _log_uye character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into log_yonetici(username, log_kitap, log_uye, zaman)
	values(_username, '-', _log_uye, current_date);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 X   DROP FUNCTION public.llog_uye(_username character varying, _log_uye character varying);
       public          postgres    false            �            1255    17060 C   log_kayıt(character varying, character varying, character varying)    FUNCTION     f  CREATE FUNCTION public."log_kayıt"(_username character varying, _gorev character varying, _islem character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into log_yonetici(username, gorev, islem, zaman)
	values(_username, _gorev, _islem, current_date);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 t   DROP FUNCTION public."log_kayıt"(_username character varying, _gorev character varying, _islem character varying);
       public          postgres    false            �            1255    17027 /   log_kitap(character varying, character varying)    FUNCTION     F  CREATE FUNCTION public.log_kitap(_username character varying, _log_kitap character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into log_yonetici(username, log_kitap, zaman)
	values(_username, _log_kitap, current_date);
	if found then --Başarılı
		return 1;
	else return 0; --Hata
	end if;
end
$$;
 [   DROP FUNCTION public.log_kitap(_username character varying, _log_kitap character varying);
       public          postgres    false            �            1255    16891 h   st_update(character varying, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.st_update(_tc character varying, _uye_ad character varying, _uye_soyad character varying, _uye_telefon character varying, _uye_sifre character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
                                begin
                                    update uyebilgi
                                    set	
                                        uye_ad = _uye_ad,
                                        uye_soyad = _uye_soyad,
                                        uye_telefon = _uye_telefon,
                                        uye_sifre = _uye_sifre
                                    where tc = _tc;
                                    if found then 
                                        return 1;
                                    else 
                                        return 0;
                                    end if;
                                end
                                $$;
 �   DROP FUNCTION public.st_update(_tc character varying, _uye_ad character varying, _uye_soyad character varying, _uye_telefon character varying, _uye_sifre character varying);
       public          postgres    false            �            1255    16815 i   uye_insert(character varying, character varying, character varying, character varying, character varying)    FUNCTION     �  CREATE FUNCTION public.uye_insert(_tc character varying, _uye_ad character varying, _uye_soyad character varying, _uye_telefon character varying, _uye_sifre character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
                                begin
                                    insert into uyebilgi(tc, uye_ad, uye_soyad, uye_telefon, uye_sifre)
                                    values(_tc, _uye_ad, _uye_soyad, _uye_telefon, _uye_sifre);
                                    if found then --Başarılı
                                        return 1;
                                    else return 0; --Hata
                                    end if;
                                end
                                $$;
 �   DROP FUNCTION public.uye_insert(_tc character varying, _uye_ad character varying, _uye_soyad character varying, _uye_telefon character varying, _uye_sifre character varying);
       public          postgres    false            �            1255    16998 4   yönetici_ekle(character varying, character varying)    FUNCTION       CREATE FUNCTION public."yönetici_ekle"(_username character varying, _password character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
                        begin
	                        insert into userr(username,password)
	                        values(_username,_password);
	                        if found then --Başarılı
		                        return 1;
	                        else return 0; --Hata
	                        end if;
                        end
                        $$;
 a   DROP FUNCTION public."yönetici_ekle"(_username character varying, _password character varying);
       public          postgres    false            �            1259    17064    emanet_kitap    TABLE     �   CREATE TABLE public.emanet_kitap (
    emanet_id integer NOT NULL,
    tc character varying(11) NOT NULL,
    kitap_ad character varying(50) NOT NULL,
    emanet_date date NOT NULL,
    teslim_date date NOT NULL
);
     DROP TABLE public.emanet_kitap;
       public         heap    postgres    false            �            1259    17063    emanet_kitap_emanet_id_seq    SEQUENCE     �   CREATE SEQUENCE public.emanet_kitap_emanet_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.emanet_kitap_emanet_id_seq;
       public          postgres    false    219            ?           0    0    emanet_kitap_emanet_id_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.emanet_kitap_emanet_id_seq OWNED BY public.emanet_kitap.emanet_id;
          public          postgres    false    218            �            1259    16971    kitap    TABLE     <  CREATE TABLE public.kitap (
    kitap_id integer NOT NULL,
    kitap_ad character varying(50) NOT NULL,
    yazar character varying(50) NOT NULL,
    tur character varying(50) NOT NULL,
    yayin_evi character varying(50) NOT NULL,
    basim character varying(4) NOT NULL,
    sayfa character varying(4) NOT NULL
);
    DROP TABLE public.kitap;
       public         heap    postgres    false            �            1259    16970    kitap_kitap_id_seq    SEQUENCE     �   CREATE SEQUENCE public.kitap_kitap_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.kitap_kitap_id_seq;
       public          postgres    false    215            @           0    0    kitap_kitap_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.kitap_kitap_id_seq OWNED BY public.kitap.kitap_id;
          public          postgres    false    214            �            1259    17054    log_yonetici    TABLE     �   CREATE TABLE public.log_yonetici (
    id integer NOT NULL,
    username character varying(10) NOT NULL,
    gorev character varying(50) NOT NULL,
    islem character varying(20) NOT NULL,
    zaman date NOT NULL
);
     DROP TABLE public.log_yonetici;
       public         heap    postgres    false            �            1259    17053    log_yonetici_id_seq    SEQUENCE     �   CREATE SEQUENCE public.log_yonetici_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.log_yonetici_id_seq;
       public          postgres    false    217            A           0    0    log_yonetici_id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.log_yonetici_id_seq OWNED BY public.log_yonetici.id;
          public          postgres    false    216            �            1259    17069    okunan_kitap    TABLE     �   CREATE TABLE public.okunan_kitap (
    id integer NOT NULL,
    tc character varying(11) NOT NULL,
    kitap_ad character varying(50) NOT NULL
);
     DROP TABLE public.okunan_kitap;
       public         heap    postgres    false            �            1259    17068    okunan_kitap_id_seq    SEQUENCE     �   CREATE SEQUENCE public.okunan_kitap_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.okunan_kitap_id_seq;
       public          postgres    false    221            B           0    0    okunan_kitap_id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.okunan_kitap_id_seq OWNED BY public.okunan_kitap.id;
          public          postgres    false    220            �            1259    17074    userr    TABLE     �   CREATE TABLE public.userr (
    id integer NOT NULL,
    username character varying(10) NOT NULL,
    password character varying(8) NOT NULL
);
    DROP TABLE public.userr;
       public         heap    postgres    false            �            1259    17073    userr_id_seq    SEQUENCE     �   CREATE SEQUENCE public.userr_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.userr_id_seq;
       public          postgres    false    223            C           0    0    userr_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.userr_id_seq OWNED BY public.userr.id;
          public          postgres    false    222            �            1259    17098    uyebilgi    TABLE       CREATE TABLE public.uyebilgi (
    id integer NOT NULL,
    tc character varying(11) NOT NULL,
    uye_ad character varying(50) NOT NULL,
    uye_soyad character varying(30) NOT NULL,
    uye_telefon character varying(14) NOT NULL,
    uye_sifre character varying(8)
);
    DROP TABLE public.uyebilgi;
       public         heap    postgres    false            �            1259    17097    uyebilgi_id_seq    SEQUENCE     �   CREATE SEQUENCE public.uyebilgi_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.uyebilgi_id_seq;
       public          postgres    false    225            D           0    0    uyebilgi_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.uyebilgi_id_seq OWNED BY public.uyebilgi.id;
          public          postgres    false    224            �           2604    17067    emanet_kitap emanet_id    DEFAULT     �   ALTER TABLE ONLY public.emanet_kitap ALTER COLUMN emanet_id SET DEFAULT nextval('public.emanet_kitap_emanet_id_seq'::regclass);
 E   ALTER TABLE public.emanet_kitap ALTER COLUMN emanet_id DROP DEFAULT;
       public          postgres    false    219    218    219            �           2604    16974    kitap kitap_id    DEFAULT     p   ALTER TABLE ONLY public.kitap ALTER COLUMN kitap_id SET DEFAULT nextval('public.kitap_kitap_id_seq'::regclass);
 =   ALTER TABLE public.kitap ALTER COLUMN kitap_id DROP DEFAULT;
       public          postgres    false    215    214    215            �           2604    17057    log_yonetici id    DEFAULT     r   ALTER TABLE ONLY public.log_yonetici ALTER COLUMN id SET DEFAULT nextval('public.log_yonetici_id_seq'::regclass);
 >   ALTER TABLE public.log_yonetici ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217            �           2604    17072    okunan_kitap id    DEFAULT     r   ALTER TABLE ONLY public.okunan_kitap ALTER COLUMN id SET DEFAULT nextval('public.okunan_kitap_id_seq'::regclass);
 >   ALTER TABLE public.okunan_kitap ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    221    220    221            �           2604    17077    userr id    DEFAULT     d   ALTER TABLE ONLY public.userr ALTER COLUMN id SET DEFAULT nextval('public.userr_id_seq'::regclass);
 7   ALTER TABLE public.userr ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    222    223            �           2604    17101    uyebilgi id    DEFAULT     j   ALTER TABLE ONLY public.uyebilgi ALTER COLUMN id SET DEFAULT nextval('public.uyebilgi_id_seq'::regclass);
 :   ALTER TABLE public.uyebilgi ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    224    225    225            2          0    17064    emanet_kitap 
   TABLE DATA           Y   COPY public.emanet_kitap (emanet_id, tc, kitap_ad, emanet_date, teslim_date) FROM stdin;
    public          postgres    false    219   0d       .          0    16971    kitap 
   TABLE DATA           X   COPY public.kitap (kitap_id, kitap_ad, yazar, tur, yayin_evi, basim, sayfa) FROM stdin;
    public          postgres    false    215   �d       0          0    17054    log_yonetici 
   TABLE DATA           I   COPY public.log_yonetici (id, username, gorev, islem, zaman) FROM stdin;
    public          postgres    false    217   �g       4          0    17069    okunan_kitap 
   TABLE DATA           8   COPY public.okunan_kitap (id, tc, kitap_ad) FROM stdin;
    public          postgres    false    221   �h       6          0    17074    userr 
   TABLE DATA           7   COPY public.userr (id, username, password) FROM stdin;
    public          postgres    false    223   3i       8          0    17098    uyebilgi 
   TABLE DATA           U   COPY public.uyebilgi (id, tc, uye_ad, uye_soyad, uye_telefon, uye_sifre) FROM stdin;
    public          postgres    false    225   ei       E           0    0    emanet_kitap_emanet_id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public.emanet_kitap_emanet_id_seq', 6, true);
          public          postgres    false    218            F           0    0    kitap_kitap_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.kitap_kitap_id_seq', 20, true);
          public          postgres    false    214            G           0    0    log_yonetici_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.log_yonetici_id_seq', 20, true);
          public          postgres    false    216            H           0    0    okunan_kitap_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.okunan_kitap_id_seq', 2, true);
          public          postgres    false    220            I           0    0    userr_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.userr_id_seq', 1, true);
          public          postgres    false    222            J           0    0    uyebilgi_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.uyebilgi_id_seq', 3, true);
          public          postgres    false    224            �           2606    17086    emanet_kitap emanet_kitap_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.emanet_kitap
    ADD CONSTRAINT emanet_kitap_pkey PRIMARY KEY (emanet_id);
 H   ALTER TABLE ONLY public.emanet_kitap DROP CONSTRAINT emanet_kitap_pkey;
       public            postgres    false    219            �           2606    16976    kitap kitap_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.kitap
    ADD CONSTRAINT kitap_pkey PRIMARY KEY (kitap_id);
 :   ALTER TABLE ONLY public.kitap DROP CONSTRAINT kitap_pkey;
       public            postgres    false    215            �           2606    17059    log_yonetici log_yonetici_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.log_yonetici
    ADD CONSTRAINT log_yonetici_pkey PRIMARY KEY (id);
 H   ALTER TABLE ONLY public.log_yonetici DROP CONSTRAINT log_yonetici_pkey;
       public            postgres    false    217            �           2606    17088    okunan_kitap okunan_kitap_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.okunan_kitap
    ADD CONSTRAINT okunan_kitap_pkey PRIMARY KEY (id);
 H   ALTER TABLE ONLY public.okunan_kitap DROP CONSTRAINT okunan_kitap_pkey;
       public            postgres    false    221            �           2606    17090    userr userr_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.userr
    ADD CONSTRAINT userr_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.userr DROP CONSTRAINT userr_pkey;
       public            postgres    false    223            2   W   x�3�442�0742302�vu;����5�����X��P���46�2�4212�050�04�<��/��O��U��U!���<G\:c���� z�/      .   �  x�eTK��6\�N���<X�ٖ۲�i��r���[s�A�{�h�2 X��bWuU��8߇,mO��֫={:�w#Y���g6��wj�15�Ş�ݢZ>Ã�����;'� gIi�;;�I>?e�mToՊ��}i�k�Ǟ�eg��t��@��\ҫ�� kZn�՚ҘF'�dqV��?�7�$�Yh�[E��hzV�6�jC�t{S�W��}�z��✾滲�ޮU>*T���D�D���ҳ	z����$q��q�C�/ܢ|�z^Q_�� :Nq�P5B��C�Հ��5��u��A��^/�lb�r�W�x�aVV:B7.��=��/X��,�.t����<�))�R'!s�Z������{��� �U�^o�Ym�zAF���i{b�#(�=� RǦ4�R`Z�VUCQ�d���|o�|;�eq���Dtx�لT�3�Ͷ���X��U�󠉧ۀ2�mȯ�������]U/�!+��1&9	�撔R�PD��������Ň$�E�E?pJ��eU�ȣW���笈�h�i�G�����)�,��������ج	��|T2���>*�f�$�*��H���5���)3W��p3��\B�y�@V��DR2�1t㷖>����+z��2�}�+�!�?�7����+�>�O7×�.Rxpy�I�K���ם��1,?�vL����4�؊�����������C\����?����\w�      0   W  x���k�� ��*�@5�RoJ������n�d�C��ӎeba  ��s�^���"ƫ�b���D�D���<�Q���w���/ZC��_q"��b���' �/����.hY3z�~�&�@ֳ_zu���#,D����a�.�~q7� {xPJ����[���!�y�$���P��8�j;�ČFʣ~��:2���K\�i9�U�O�~*���x��:a�Zd�Y�I2�Hw�DL�ϝI��H���z^/��z�.�12N�^(�dtc�dʸ,�Z�䶶¬Jk�th�#5˚��uC��<�u{�l��/�o��!���MJ��a�� 4��      4   1   x�3�4212�050�04�<��/��O��U��W�Hǣ���b���� ��[      6   "   x�3�t�<:����NC#cS3s�=... m��      8   u   x�3�4212�050�04�t�<:����N�Р�P�У�85L�-5�L�u-MM9�3KLM��9��-�����8�]�9�A������������	PCjQJj���1W� _s      