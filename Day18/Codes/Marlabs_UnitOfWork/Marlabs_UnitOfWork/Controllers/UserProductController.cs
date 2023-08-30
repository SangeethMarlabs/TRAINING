using Marlabs_UnitOfWork.DTOs;
using Marlabs_UnitOfWork.Models;
using Marlabs_UnitOfWork.UOW;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProductController : ControllerBase
    {
        private IUnitOfWorkUOW _unitOfWork;
        public UserProductController(IUnitOfWorkUOW unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpPost("CreateUserProduct")]
        public int Create(UserProductDTO up)
        {
            User objUser = new User
            {
                UserName = up.UserName,
                UserEmail = up.UserEmail,
                UserContactNo = up.UserContactNo,
                UserAddress = up.UserAddress
            };
            Product objProduct = new Product
            {
                ProductName = up.ProductName,
                ProductCategory = up.ProductCategory,
                ProductDesc = up.ProductDesc,
                ProductPrice = up.ProductPrice,
                user = objUser
            };
            _unitOfWork.User.AddUser(objUser);
            _unitOfWork.Product.AddProduct(objProduct);
            _unitOfWork.Complete();
            _unitOfWork.Dispose();
            return 1;
        }


        [HttpPost("UpdateUserProduct")]
        public int Update(UserProductDTO up)
        {
            User objUser = new User
            {
                UserId = up.UserId,
                UserName = up.UserName,
                UserEmail = up.UserEmail,
                UserContactNo = up.UserContactNo,
                UserAddress = up.UserAddress
            };
            Product objProduct = new Product
            {
                ProductId = up.ProductId,
                ProductName = up.ProductName,
                ProductCategory = up.ProductCategory,
                ProductDesc = up.ProductDesc,
                ProductPrice = up.ProductPrice,
                user = objUser
            };
            _unitOfWork.User.AddUser(objUser);
            _unitOfWork.Product.AddProduct(objProduct);
            _unitOfWork.Complete();
            _unitOfWork.Dispose();
            return 1;
        }

        [HttpGet("GetUserProduct")]
        public List<UserProductListDTO> GetUserProduct()
        {
            List<UserProductListDTO> userProductListDTOs = new List<UserProductListDTO>();
            UserProductListDTO objUserProductListDTO = new UserProductListDTO();
            List<ProductDTO> lstP = new List<ProductDTO>();
            var lstUsers = _unitOfWork.User.GetUsers();
            var lstProducts = _unitOfWork.Product.GetProducts();

            foreach (var item in lstUsers)
            {
                objUserProductListDTO = new UserProductListDTO();
                ProductDTO objproduct = new ProductDTO();
                lstP = new List<ProductDTO>();

                objUserProductListDTO.UserId = item.UserId;
                objUserProductListDTO.UserName = item.UserName;
                objUserProductListDTO.UserContactNo = item.UserContactNo;
                objUserProductListDTO.UserEmail = item.UserEmail;
                objUserProductListDTO.UserAddress = item.UserAddress;

                var Products = (from p in lstProducts where p.user.UserId == item.UserId select p).ToList().Distinct();

                foreach (var product in Products)
                {
                    objproduct = new ProductDTO();
                    objproduct.ProductId = product.ProductId;
                    objproduct.ProductName = product.ProductName;
                    objproduct.ProductPrice = product.ProductPrice;
                    objproduct.ProductCategory = product.ProductCategory;
                    objproduct.ProductDesc = product.ProductDesc;
                    lstP.Add(objproduct);
                }
                objUserProductListDTO.lstProduct = lstP;
                userProductListDTOs.Add(objUserProductListDTO);
            }
            return userProductListDTOs;
        }
    }
}
