PGDMP         1                z            BahcemDataBase    15.1    15.1 D    a           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            b           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            c           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            d           1262    19474    BahcemDataBase    DATABASE     �   CREATE DATABASE "BahcemDataBase" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
     DROP DATABASE "BahcemDataBase";
                postgres    false            �            1255    19685    totalcustomerdelete()    FUNCTION     �   CREATE FUNCTION public.totalcustomerdelete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totalcustomer=totalcustomer-1;
return new;
end;
$$;
 ,   DROP FUNCTION public.totalcustomerdelete();
       public          postgres    false            �            1255    19677    totalcustomerupdate()    FUNCTION     �   CREATE FUNCTION public.totalcustomerupdate() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totalcustomer=totalcustomer+1;
return new;
end;
$$;
 ,   DROP FUNCTION public.totalcustomerupdate();
       public          postgres    false            �            1255    19689    totaldealerdelete()    FUNCTION     �   CREATE FUNCTION public.totaldealerdelete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totaldealer=totaldealer-1;
return new;
end;
$$;
 *   DROP FUNCTION public.totaldealerdelete();
       public          postgres    false            �            1255    19681    totaldealerupdate()    FUNCTION     �   CREATE FUNCTION public.totaldealerupdate() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totaldealer=totaldealer+1;
return new;
end;
$$;
 *   DROP FUNCTION public.totaldealerupdate();
       public          postgres    false            �            1255    19687    totalorderdelete()    FUNCTION     �   CREATE FUNCTION public.totalorderdelete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totalorder=totalorder-1;
return new;
end;
$$;
 )   DROP FUNCTION public.totalorderdelete();
       public          postgres    false            �            1255    19679    totalorderupdate()    FUNCTION     �   CREATE FUNCTION public.totalorderupdate() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totalorder=totalorder+1;
return new;
end;
$$;
 )   DROP FUNCTION public.totalorderupdate();
       public          postgres    false            �            1255    19691    totalworkerdelete()    FUNCTION     �   CREATE FUNCTION public.totalworkerdelete() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totalworker=totalworker-1;
return new;
end;
$$;
 *   DROP FUNCTION public.totalworkerdelete();
       public          postgres    false            �            1255    19683    totalworkerupdate()    FUNCTION     �   CREATE FUNCTION public.totalworkerupdate() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
update datastats set totalworker=totalworker+1;
return new;
end;
$$;
 *   DROP FUNCTION public.totalworkerupdate();
       public          postgres    false            �            1259    19475 	   customers    TABLE     +  CREATE TABLE public.customers (
    custid integer NOT NULL,
    custname character varying(50) NOT NULL,
    custemail character varying(100) NOT NULL,
    custage integer NOT NULL,
    custcity character varying(20) NOT NULL,
    custphone character varying(20) NOT NULL,
    custjoindate date
);
    DROP TABLE public.customers;
       public         heap    postgres    false            �            1259    19669 	   datastats    TABLE     �   CREATE TABLE public.datastats (
    totalcustomer integer,
    totalorder integer,
    totaldealer integer,
    totalworker integer,
    statid integer DEFAULT 1 NOT NULL
);
    DROP TABLE public.datastats;
       public         heap    postgres    false            �            1259    19505    dealers    TABLE     �   CREATE TABLE public.dealers (
    dealerid integer NOT NULL,
    dealername character varying(50) NOT NULL,
    dealercity character varying(20) NOT NULL,
    dealeraddress character varying(100) NOT NULL,
    workerid integer,
    managerid integer
);
    DROP TABLE public.dealers;
       public         heap    postgres    false            �            1259    19519    images    TABLE     v   CREATE TABLE public.images (
    imageid integer NOT NULL,
    imageurl character varying(200),
    imagedate date
);
    DROP TABLE public.images;
       public         heap    postgres    false            �            1259    19526    managers    TABLE     Q  CREATE TABLE public.managers (
    managerid integer NOT NULL,
    managername character varying(50) NOT NULL,
    managerage integer NOT NULL,
    manageremail character varying(100) NOT NULL,
    managercity character varying(20) NOT NULL,
    managerphone character varying(20) NOT NULL,
    managerdate date,
    dealerid integer
);
    DROP TABLE public.managers;
       public         heap    postgres    false            �            1259    19490    ordercategories    TABLE     �   CREATE TABLE public.ordercategories (
    ordercategoryid integer NOT NULL,
    ordercategoryname character varying(40) NOT NULL,
    ordercategoryinfo character varying(100)
);
 #   DROP TABLE public.ordercategories;
       public         heap    postgres    false            �            1259    19480    orders    TABLE     �   CREATE TABLE public.orders (
    orderid integer NOT NULL,
    custid integer,
    orderdate date,
    orderprice integer NOT NULL,
    workerid integer,
    ordercategoryid integer,
    imageid integer,
    receiptid integer
);
    DROP TABLE public.orders;
       public         heap    postgres    false            �            1259    19558    orderworkers    TABLE     �   CREATE TABLE public.orderworkers (
    orderworkerid integer NOT NULL,
    orderid integer NOT NULL,
    workerid integer NOT NULL
);
     DROP TABLE public.orderworkers;
       public         heap    postgres    false            �            1259    19485    receipts    TABLE     �   CREATE TABLE public.receipts (
    receiptid integer NOT NULL,
    receiptaddress character varying(100) NOT NULL,
    receiptpaid boolean
);
    DROP TABLE public.receipts;
       public         heap    postgres    false            �            1259    19500    salaries    TABLE     �   CREATE TABLE public.salaries (
    workerid integer NOT NULL,
    salary integer NOT NULL,
    prevsalary character varying(100)
);
    DROP TABLE public.salaries;
       public         heap    postgres    false            �            1259    19512    tools    TABLE     �   CREATE TABLE public.tools (
    toolid integer NOT NULL,
    toolname character varying(50) NOT NULL,
    toolcount integer NOT NULL,
    dealerid integer
);
    DROP TABLE public.tools;
       public         heap    postgres    false            �            1259    19493    workers    TABLE     M  CREATE TABLE public.workers (
    workerid integer NOT NULL,
    workername character varying(50) NOT NULL,
    workeremail character varying(100) NOT NULL,
    workerage integer NOT NULL,
    workercity character varying(20) NOT NULL,
    workerphone character varying(20) NOT NULL,
    workerjoindate date,
    dealerid integer
);
    DROP TABLE public.workers;
       public         heap    postgres    false            S          0    19475 	   customers 
   TABLE DATA           l   COPY public.customers (custid, custname, custemail, custage, custcity, custphone, custjoindate) FROM stdin;
    public          postgres    false    214   �V       ^          0    19669 	   datastats 
   TABLE DATA           `   COPY public.datastats (totalcustomer, totalorder, totaldealer, totalworker, statid) FROM stdin;
    public          postgres    false    225   �W       Y          0    19505    dealers 
   TABLE DATA           g   COPY public.dealers (dealerid, dealername, dealercity, dealeraddress, workerid, managerid) FROM stdin;
    public          postgres    false    220   �W       [          0    19519    images 
   TABLE DATA           >   COPY public.images (imageid, imageurl, imagedate) FROM stdin;
    public          postgres    false    222   �X       \          0    19526    managers 
   TABLE DATA           �   COPY public.managers (managerid, managername, managerage, manageremail, managercity, managerphone, managerdate, dealerid) FROM stdin;
    public          postgres    false    223   zY       V          0    19490    ordercategories 
   TABLE DATA           `   COPY public.ordercategories (ordercategoryid, ordercategoryname, ordercategoryinfo) FROM stdin;
    public          postgres    false    217   Z       T          0    19480    orders 
   TABLE DATA           w   COPY public.orders (orderid, custid, orderdate, orderprice, workerid, ordercategoryid, imageid, receiptid) FROM stdin;
    public          postgres    false    215   ?Z       ]          0    19558    orderworkers 
   TABLE DATA           H   COPY public.orderworkers (orderworkerid, orderid, workerid) FROM stdin;
    public          postgres    false    224   �Z       U          0    19485    receipts 
   TABLE DATA           J   COPY public.receipts (receiptid, receiptaddress, receiptpaid) FROM stdin;
    public          postgres    false    216   �Z       X          0    19500    salaries 
   TABLE DATA           @   COPY public.salaries (workerid, salary, prevsalary) FROM stdin;
    public          postgres    false    219   [       Z          0    19512    tools 
   TABLE DATA           F   COPY public.tools (toolid, toolname, toolcount, dealerid) FROM stdin;
    public          postgres    false    221   [       W          0    19493    workers 
   TABLE DATA           �   COPY public.workers (workerid, workername, workeremail, workerage, workercity, workerphone, workerjoindate, dealerid) FROM stdin;
    public          postgres    false    218   �[       �           2606    19479    customers Customer_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.customers
    ADD CONSTRAINT "Customer_pkey" PRIMARY KEY (custid);
 C   ALTER TABLE ONLY public.customers DROP CONSTRAINT "Customer_pkey";
       public            postgres    false    214            �           2606    19511    dealers Dealer_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.dealers
    ADD CONSTRAINT "Dealer_pkey" PRIMARY KEY (dealerid);
 ?   ALTER TABLE ONLY public.dealers DROP CONSTRAINT "Dealer_pkey";
       public            postgres    false    220            �           2606    19525    images Image_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.images
    ADD CONSTRAINT "Image_pkey" PRIMARY KEY (imageid);
 =   ALTER TABLE ONLY public.images DROP CONSTRAINT "Image_pkey";
       public            postgres    false    222            �           2606    19530    managers Manager_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.managers
    ADD CONSTRAINT "Manager_pkey" PRIMARY KEY (managerid);
 A   ALTER TABLE ONLY public.managers DROP CONSTRAINT "Manager_pkey";
       public            postgres    false    223            �           2606    19584 "   ordercategories OrderCategory_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.ordercategories
    ADD CONSTRAINT "OrderCategory_pkey" PRIMARY KEY (ordercategoryid);
 N   ALTER TABLE ONLY public.ordercategories DROP CONSTRAINT "OrderCategory_pkey";
       public            postgres    false    217            �           2606    19562    orderworkers OrderWorker_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.orderworkers
    ADD CONSTRAINT "OrderWorker_pkey" PRIMARY KEY (orderworkerid);
 I   ALTER TABLE ONLY public.orderworkers DROP CONSTRAINT "OrderWorker_pkey";
       public            postgres    false    224            �           2606    19484    orders Order_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT "Order_pkey" PRIMARY KEY (orderid);
 =   ALTER TABLE ONLY public.orders DROP CONSTRAINT "Order_pkey";
       public            postgres    false    215            �           2606    19489    receipts Receipt_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.receipts
    ADD CONSTRAINT "Receipt_pkey" PRIMARY KEY (receiptid);
 A   ALTER TABLE ONLY public.receipts DROP CONSTRAINT "Receipt_pkey";
       public            postgres    false    216            �           2606    19504    salaries Salary_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.salaries
    ADD CONSTRAINT "Salary_pkey" PRIMARY KEY (workerid);
 @   ALTER TABLE ONLY public.salaries DROP CONSTRAINT "Salary_pkey";
       public            postgres    false    219            �           2606    19518    tools Tool_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.tools
    ADD CONSTRAINT "Tool_pkey" PRIMARY KEY (toolid);
 ;   ALTER TABLE ONLY public.tools DROP CONSTRAINT "Tool_pkey";
       public            postgres    false    221            �           2606    19499    workers Worker_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.workers
    ADD CONSTRAINT "Worker_pkey" PRIMARY KEY (workerid);
 ?   ALTER TABLE ONLY public.workers DROP CONSTRAINT "Worker_pkey";
       public            postgres    false    218            �           2606    19674    datastats datastats_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.datastats
    ADD CONSTRAINT datastats_pkey PRIMARY KEY (statid);
 B   ALTER TABLE ONLY public.datastats DROP CONSTRAINT datastats_pkey;
       public            postgres    false    225            �           2620    19678    customers totalcustomertrigger    TRIGGER     �   CREATE TRIGGER totalcustomertrigger AFTER INSERT ON public.customers FOR EACH ROW EXECUTE FUNCTION public.totalcustomerupdate();
 7   DROP TRIGGER totalcustomertrigger ON public.customers;
       public          postgres    false    214    226            �           2620    19686 !   customers totalcustomertriggerdel    TRIGGER     �   CREATE TRIGGER totalcustomertriggerdel AFTER DELETE ON public.customers FOR EACH ROW EXECUTE FUNCTION public.totalcustomerdelete();
 :   DROP TRIGGER totalcustomertriggerdel ON public.customers;
       public          postgres    false    214    230            �           2620    19682    dealers totaldealertrigger    TRIGGER     {   CREATE TRIGGER totaldealertrigger AFTER INSERT ON public.dealers FOR EACH ROW EXECUTE FUNCTION public.totaldealerupdate();
 3   DROP TRIGGER totaldealertrigger ON public.dealers;
       public          postgres    false    220    228            �           2620    19690    dealers totaldealertriggerdel    TRIGGER     ~   CREATE TRIGGER totaldealertriggerdel AFTER DELETE ON public.dealers FOR EACH ROW EXECUTE FUNCTION public.totaldealerdelete();
 6   DROP TRIGGER totaldealertriggerdel ON public.dealers;
       public          postgres    false    220    232            �           2620    19680    orders totalordertrigger    TRIGGER     x   CREATE TRIGGER totalordertrigger AFTER INSERT ON public.orders FOR EACH ROW EXECUTE FUNCTION public.totalorderupdate();
 1   DROP TRIGGER totalordertrigger ON public.orders;
       public          postgres    false    227    215            �           2620    19688    orders totalordertriggerdel    TRIGGER     {   CREATE TRIGGER totalordertriggerdel AFTER DELETE ON public.orders FOR EACH ROW EXECUTE FUNCTION public.totalorderdelete();
 4   DROP TRIGGER totalordertriggerdel ON public.orders;
       public          postgres    false    215    231            �           2620    19684    workers totalworkertrigger    TRIGGER     {   CREATE TRIGGER totalworkertrigger AFTER INSERT ON public.workers FOR EACH ROW EXECUTE FUNCTION public.totalworkerupdate();
 3   DROP TRIGGER totalworkertrigger ON public.workers;
       public          postgres    false    229    218            �           2620    19692    workers totalworkertriggerdel    TRIGGER     ~   CREATE TRIGGER totalworkertriggerdel AFTER DELETE ON public.workers FOR EACH ROW EXECUTE FUNCTION public.totalworkerdelete();
 6   DROP TRIGGER totalworkertriggerdel ON public.workers;
       public          postgres    false    233    218            �           2606    19573    dealers Dealer_managerID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dealers
    ADD CONSTRAINT "Dealer_managerID_fkey" FOREIGN KEY (managerid) REFERENCES public.managers(managerid);
 I   ALTER TABLE ONLY public.dealers DROP CONSTRAINT "Dealer_managerID_fkey";
       public          postgres    false    223    3244    220            �           2606    19563    dealers Dealer_workerID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.dealers
    ADD CONSTRAINT "Dealer_workerID_fkey" FOREIGN KEY (workerid) REFERENCES public.workers(workerid);
 H   ALTER TABLE ONLY public.dealers DROP CONSTRAINT "Dealer_workerID_fkey";
       public          postgres    false    220    3234    218            �           2606    19600 %   orderworkers OrderWorker_orderID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orderworkers
    ADD CONSTRAINT "OrderWorker_orderID_fkey" FOREIGN KEY (orderid) REFERENCES public.orders(orderid);
 Q   ALTER TABLE ONLY public.orderworkers DROP CONSTRAINT "OrderWorker_orderID_fkey";
       public          postgres    false    224    215    3228            �           2606    19605 &   orderworkers OrderWorker_workerID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orderworkers
    ADD CONSTRAINT "OrderWorker_workerID_fkey" FOREIGN KEY (workerid) REFERENCES public.workers(workerid);
 R   ALTER TABLE ONLY public.orderworkers DROP CONSTRAINT "OrderWorker_workerID_fkey";
       public          postgres    false    218    3234    224            �           2606    19620    orders Order_custID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT "Order_custID_fkey" FOREIGN KEY (custid) REFERENCES public.customers(custid);
 D   ALTER TABLE ONLY public.orders DROP CONSTRAINT "Order_custID_fkey";
       public          postgres    false    215    214    3226            �           2606    19590    orders Order_imageID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT "Order_imageID_fkey" FOREIGN KEY (imageid) REFERENCES public.images(imageid);
 E   ALTER TABLE ONLY public.orders DROP CONSTRAINT "Order_imageID_fkey";
       public          postgres    false    215    222    3242            �           2606    19595 !   orders Order_orderCategoryID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT "Order_orderCategoryID_fkey" FOREIGN KEY (ordercategoryid) REFERENCES public.ordercategories(ordercategoryid);
 M   ALTER TABLE ONLY public.orders DROP CONSTRAINT "Order_orderCategoryID_fkey";
       public          postgres    false    215    3232    217            �           2606    19585    orders Order_workerID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.orders
    ADD CONSTRAINT "Order_workerID_fkey" FOREIGN KEY (workerid) REFERENCES public.workers(workerid);
 F   ALTER TABLE ONLY public.orders DROP CONSTRAINT "Order_workerID_fkey";
       public          postgres    false    218    3234    215            �           2606    19615    salaries Salary_workerID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.salaries
    ADD CONSTRAINT "Salary_workerID_fkey" FOREIGN KEY (workerid) REFERENCES public.workers(workerid);
 I   ALTER TABLE ONLY public.salaries DROP CONSTRAINT "Salary_workerID_fkey";
       public          postgres    false    219    218    3234            �           2606    19638    managers managers_dealerid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.managers
    ADD CONSTRAINT managers_dealerid_fkey FOREIGN KEY (dealerid) REFERENCES public.dealers(dealerid);
 I   ALTER TABLE ONLY public.managers DROP CONSTRAINT managers_dealerid_fkey;
       public          postgres    false    223    3238    220            �           2606    19633    tools tools_dealerid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tools
    ADD CONSTRAINT tools_dealerid_fkey FOREIGN KEY (dealerid) REFERENCES public.dealers(dealerid);
 C   ALTER TABLE ONLY public.tools DROP CONSTRAINT tools_dealerid_fkey;
       public          postgres    false    221    3238    220            �           2606    19643    workers workers_dealerid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.workers
    ADD CONSTRAINT workers_dealerid_fkey FOREIGN KEY (dealerid) REFERENCES public.dealers(dealerid);
 G   ALTER TABLE ONLY public.workers DROP CONSTRAINT workers_dealerid_fkey;
       public          postgres    false    218    3238    220            S     x�]�MN�0���]�'i���V]Ub3�Vb5v��e���{aK�q��Y�7ols�	R��T7�W�R�@���k���2V�I[9����xq��)�h�f6e<��Aځ���b�4'��GUU��Y�}�t��i!qXcNO7!Ă*�����s��#D��-��WS��H�� �hs��P6���킉�ۼ]�5��<C���X�jS����S�&'�`g<��]���HK��-��D����m;���c�����      ^      x�34�4�4�4�4����� �      Y   �   x�3�tJ�8�<5W!81/91�$� �ӳ�$1/�4�38171/��ƢDNCNC.#�bǔĂĪĢ#�j��*9�'e+8'���grqqÕ{'�>��a���mU`ˌ�� �+I����SsS�8c���+F��� �p>�      [   �   x�U��N�0��˻$n�6�Ih��G$dR��h�(	����e���_l��g�ÐsH' �9��u�O��jGJ �j�yl$H� c�f���`�'t�qC�摢}{���n�-��'���(u������R�0���y��b]B̛>��K`'싨�&����Y-?x�juܱkX�c{�9�)`6���.�˻�l��4�D"���K��u=��硔�E5�U0�~��dd      \   z   x�3�tLI��41�L�����9z������%�yI�9��FFF��@�i�e�uxONjeF"��%gU)���381;��2��Y��1�kqn"��g*��f���T����1�1W� 7�,�      V   +   x�3�tIM�/J,���Cb*�`crq����	T�+F��� B�      T   <   x�E��	�0B�u���K���sT�BPA|(.{H1T�a����ԧ�#6����+C�|'�*�v      ]      x������ � �      U   I   x�3�N�N,�L�	N-J�,K��,�2��,.I�K*��	N�KN�.I-H�#��S�l�>���3�+F��� ���      X      x������ � �      Z   �   x�Mͱ
�0����):�"Iڴu�š���.W)�RI]�e;w�v�`&������(h�}G�%(��ag[m���4�iA�xdGK(cU$?�'��Iva���"�%��u����'���`�7�l��C�N��"��)|����tLɄ�7U?��_inDl      W   �   x�]�=�0���ii��lD��k��FL[�t�_oR����.���G3�4�B��nɸ��Ƿ��:p�!!"��B{f��=[�cUNSG�h�e�G"£�b<�'�����AJ����r����r�?T��@n4�>�&n�%���̣{5�/n>�M��	R�ƌ��@XJ     