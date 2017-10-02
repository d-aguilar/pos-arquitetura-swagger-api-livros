/*
 * Livro.API
 *
 * API criada para trabalho da disciplina Arquitetura de Backend e Microsserviços do curso de pós graduação em Arquitetura de Software Distribuído PUC Minas.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: diogoaguilar89@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Livro.API.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Livro :  IEquatable<Livro>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Livro" /> class.
        /// </summary>
        /// <param name="CodLivro">CodLivro (required).</param>
        /// <param name="Isbn">Isbn (required).</param>
        /// <param name="Titulo">Titulo (required).</param>
        /// <param name="PalavrasChave">PalavrasChave (required).</param>
        /// <param name="Autor">Autor (required).</param>
        public Livro(Guid? CodLivro = null, string Isbn = null, string Titulo = null, string PalavrasChave = null, Autor Autor = null)
        {
            // to ensure "CodLivro" is required (not null)
            if (CodLivro == null)
            {
                throw new InvalidDataException("CodLivro is a required property for Livro and cannot be null");
            }
            else
            {
                this.CodLivro = CodLivro;
            }
            // to ensure "Isbn" is required (not null)
            if (Isbn == null)
            {
                throw new InvalidDataException("Isbn is a required property for Livro and cannot be null");
            }
            else
            {
                this.Isbn = Isbn;
            }
            // to ensure "Titulo" is required (not null)
            if (Titulo == null)
            {
                throw new InvalidDataException("Titulo is a required property for Livro and cannot be null");
            }
            else
            {
                this.Titulo = Titulo;
            }
            // to ensure "PalavrasChave" is required (not null)
            if (PalavrasChave == null)
            {
                throw new InvalidDataException("PalavrasChave is a required property for Livro and cannot be null");
            }
            else
            {
                this.PalavrasChave = PalavrasChave;
            }
            // to ensure "Autor" is required (not null)
            if (Autor == null)
            {
                throw new InvalidDataException("Autor is a required property for Livro and cannot be null");
            }
            else
            {
                this.Autor = Autor;
            }
            
        }

        /// <summary>
        /// Gets or Sets CodLivro
        /// </summary>
        [DataMember(Name="codLivro")]
        public Guid? CodLivro { get; set; }

        /// <summary>
        /// Gets or Sets Isbn
        /// </summary>
        [DataMember(Name="isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// Gets or Sets Titulo
        /// </summary>
        [DataMember(Name="titulo")]
        public string Titulo { get; set; }

        /// <summary>
        /// Gets or Sets PalavrasChave
        /// </summary>
        [DataMember(Name="palavrasChave")]
        public string PalavrasChave { get; set; }

        /// <summary>
        /// Gets or Sets Autor
        /// </summary>
        [DataMember(Name="autor")]
        public Autor Autor { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Livro {\n");
            sb.Append("  CodLivro: ").Append(CodLivro).Append("\n");
            sb.Append("  Isbn: ").Append(Isbn).Append("\n");
            sb.Append("  Titulo: ").Append(Titulo).Append("\n");
            sb.Append("  PalavrasChave: ").Append(PalavrasChave).Append("\n");
            sb.Append("  Autor: ").Append(Autor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Livro)obj);
        }

        /// <summary>
        /// Returns true if Livro instances are equal
        /// </summary>
        /// <param name="other">Instance of Livro to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Livro other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.CodLivro == other.CodLivro ||
                    this.CodLivro != null &&
                    this.CodLivro.Equals(other.CodLivro)
                ) && 
                (
                    this.Isbn == other.Isbn ||
                    this.Isbn != null &&
                    this.Isbn.Equals(other.Isbn)
                ) && 
                (
                    this.Titulo == other.Titulo ||
                    this.Titulo != null &&
                    this.Titulo.Equals(other.Titulo)
                ) && 
                (
                    this.PalavrasChave == other.PalavrasChave ||
                    this.PalavrasChave != null &&
                    this.PalavrasChave.Equals(other.PalavrasChave)
                ) && 
                (
                    this.Autor == other.Autor ||
                    this.Autor != null &&
                    this.Autor.Equals(other.Autor)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CodLivro != null)
                    hash = hash * 59 + this.CodLivro.GetHashCode();
                if (this.Isbn != null)
                    hash = hash * 59 + this.Isbn.GetHashCode();
                if (this.Titulo != null)
                    hash = hash * 59 + this.Titulo.GetHashCode();
                if (this.PalavrasChave != null)
                    hash = hash * 59 + this.PalavrasChave.GetHashCode();
                if (this.Autor != null)
                    hash = hash * 59 + this.Autor.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Livro left, Livro right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Livro left, Livro right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
