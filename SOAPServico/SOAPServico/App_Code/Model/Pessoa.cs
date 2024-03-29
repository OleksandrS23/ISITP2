﻿//<Authors> Oleksandr Sierov & Rafael Faria </Authors>
//<Email> a16991@alunos.ipca.pt & 17004@alunos.ipca.pt </Email>
//<Institution> IPCA - Instituto Politecnico do Cávado e do Ave </Institution>
//<Version=4.1/>
//<Date>10/01/2021 <Last Change/></Date>
//<OBS></OBS>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Pessoa
/// </summary>
[DataContract]
public class Pessoa
{
    int idPessoa;
    string nome;
    string telefone;
    int nif;
    string morada;
    DateTime data;

    [DataMember]
    public int IdPessoa
    {
        get
        {
            if (idPessoa != -1)
                return idPessoa;
            else return -1;
        }
        set { if (idPessoa == -1) idPessoa = value; }
    }

    [DataMember]
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    [DataMember]
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    [DataMember]
    public int Nif
    {
        get { return nif; }
        set { nif = value; }
    }

    [DataMember]
    public string Morada
    {
        get { return morada; }
        set { morada = value; }
    }

    [DataMember]
    public DateTime Data
    {
        get { return data; }
        set { data = value; }
    }

}