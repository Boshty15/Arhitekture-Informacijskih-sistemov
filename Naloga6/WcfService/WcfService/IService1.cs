using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        OsebaVPodjetju getpodjetjeMax(string podjetje);

        [OperationContract]
        List<Oseba> getOsebeVPod();

        [OperationContract]
        Oseba getOsebaIme(string vnesenoIme);

        [OperationContract]
        Oseba minOseba();

        [OperationContract]
        List<Oseba> listOseb(string podjetje);

        [OperationContract]
        List<Podjetje> listaPodjetja(string imeOsebe);

        [OperationContract]
        string povprecna();

        [OperationContract]
        List<Oseba> getOsebeAll();


        [OperationContract]
        List<Podjetje> getPodjetjeAll();


        [OperationContract]
        bool isAdmin(string rac, string geslo);


        [OperationContract]
        Podjetje getPodjetjeWithMaxOseb();


        [OperationContract]
        Oseba getOsebaWithMaxPod();


        [OperationContract]
        int InsertNewOseba(string ime, string priimek, int letoRojstva);

        [OperationContract]
        int InsertNewPodjetje(string naziv, string panoga, int leto);

        [OperationContract]
        int InsertNewUser(string ime, string geslo, bool admin);

        [OperationContract]
        int RemoveOseba(string ime, string priimek);

        [OperationContract]
        int RemovePodjetje(string naziv);

        [OperationContract]
        int AddOsebaVPodjetje(string ime, string priimek, string nazivPod, string delovnoMesto, int letoDo);

        [OperationContract]
        int RemoveOsebeIzPodjetja(string ime, string priimek, string naziv);

        [OperationContract]
        int UpdateOsebe(string ime, string priimek, string newIme, string newPriimek, int newLeto);

        [OperationContract]
        int UpdatePodjetje(string naziv, string newNaziv, string newPanoga, int newLeto);

        [OperationContract]
        int OdstraniOsebo(int id);

        [OperationContract]
        int OdstraniPodjetje(int id);

        [OperationContract]
        int RemoveOsebeIzPodjetjaByIndex(int indexOseba, int indexPodjetej);

        [OperationContract]
        int AddOsebaVPodjetjeByIndex(int indexO, int indexP, string delovnoMesto, int letoDo);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
