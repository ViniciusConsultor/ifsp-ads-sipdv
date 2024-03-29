﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class Product
    {
        #region -Private Attributes-

        private int id;
        private long barCode;
        private string name;
        private string description;
        private string measurementUnit;
        private int quantity;
        private double stockQuantity;
        private int status;
        private float costPrice;
        private float salePrice;

        #endregion

        #region -Constructors-

        public Product()
        {

        }

        public Product(int id, long barCode, string name, string description, string measurementUnit, 
                       int quantity, double stockQuantity, int status, float costPrice, float salePrice)
        {
            this.id = id;
            this.barCode = barCode;
            this.name = name;
            this.description = description;
            this.measurementUnit = measurementUnit;
            this.quantity = quantity;
            this.stockQuantity = stockQuantity;
            this.status = status;
            this.costPrice = costPrice;
            this.salePrice = salePrice;
        }

        #endregion

        #region -Public Properties-

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public long BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string MeasurementUnit
        {
            get { return measurementUnit; }
            set { measurementUnit = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public float CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Calcula o subtotal do produto (Quantidade * Valor de Venda).
        /// </summary>
        /// <returns>Retorna o subtotal do produto</returns>
        public float CalculateSubtotal()
        {
            return this.quantity * this.salePrice;
        }

        public override string ToString()
        {
            return string.Format("{0,-13} {1,-20} {2,3} {3,7:0.00} {4,7:0.00}", this.barCode, this.name, this.quantity, this.salePrice, CalculateSubtotal());
        }

        #endregion
    }
}
