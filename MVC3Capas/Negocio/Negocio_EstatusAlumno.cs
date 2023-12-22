using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Datos;
using Entidades;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

namespace Negocio
{
    public class Negocio_EstatusAlumno
    {
        //private InstitutoTichEntities1 _DBModel = new InstitutoTichEntities1();
        private List<EstatusAlumno> _listaEstatusAlumnos;
        private EstatusAlumno _estatus;
        string urlWebAPI = ConfigurationManager.AppSettings["urlWebAPI"];

        public void Actualizar(EstatusAlumno estatus)
        {
            //_DBModel.Entry(estatus).State = EntityState.Modified;
            //_DBModel.SaveChanges();
            using (var client = new HttpClient())
            {
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(estatus), Encoding.UTF8);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var postTask = client.PutAsync(urlWebAPI + $"/{estatus.id}", httpContent);
                postTask.Wait();
                var result = postTask.Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");
                }
            }
        }

        public void Agregar(EstatusAlumno estatus)
        {
            //_DBModel.EstatusAlumno.Add(estatus);
            //_DBModel.SaveChanges();
            try
            {
                using (var client = new HttpClient())
                {
                    HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(estatus), Encoding.UTF8);
                    httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var postTask = client.PostAsync(urlWebAPI, httpContent);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        string json = readTask.Result;
                        _estatus = JsonConvert.DeserializeObject<EstatusAlumno>(json);
                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");
            }
        }

        public EstatusAlumno Consulta(int id)
        {
            //_DBModel.Configuration.LazyLoadingEnabled = false;
            //_estatus = _DBModel.EstatusAlumno.Find(id);
            try
            {
                using (var client = new HttpClient())
                {
                    var responseTask = client.GetAsync(urlWebAPI + $"/{id}");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        string json = readTask.Result;
                        _estatus = JsonConvert.DeserializeObject<EstatusAlumno>(json);
                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");
                    }

                }
                return _estatus;
            }
            catch (Exception ex)
            {
                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");
            }
        }

        public List<EstatusAlumno> Consultar()
        {
            //_listaEstatusAlumnos = _DBModel.EstatusAlumno.ToList();
            try
            {
                using (var client = new HttpClient())
                {
                    var responseTask = client.GetAsync(urlWebAPI);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        string json = readTask.Result;
                        _listaEstatusAlumnos = JsonConvert.DeserializeObject<List<EstatusAlumno>>(json);
                    }
                    else
                    {
                        throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"WebAPI. Respondio con error.{ex.Message}");
            }
            return _listaEstatusAlumnos;
        }

        public void Eliminar(int id)
        {
            //_estatus = _DBModel.EstatusAlumno.Find(id);
            //_DBModel.EstatusAlumno.Remove(_estatus);
            //_DBModel.SaveChanges();

            using (var client = new HttpClient())
            {
                var responseTask = client.DeleteAsync(urlWebAPI + $"/{id}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (!result.IsSuccessStatusCode)
                {
                    throw new Exception($"WebAPI. Respondio con error.{result.StatusCode}");
                }

            }
        } 
    }
}
