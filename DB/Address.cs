//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    
    public partial class Address
    {
        
    	private string _Street;
    	public string Street 
    	{		
    		get
    		{
    			return _Street;
    		} 
    		set
    		{
    			_Street = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
        
    	private string _HouseNumber;
    	public string HouseNumber 
    	{		
    		get
    		{
    			return _HouseNumber;
    		} 
    		set
    		{
    			_HouseNumber = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
        
    	private string _ApartmentNumber;
    	public string ApartmentNumber 
    	{		
    		get
    		{
    			return _ApartmentNumber;
    		} 
    		set
    		{
    			_ApartmentNumber = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
        
    	private string _PostalCode;
    	public string PostalCode 
    	{		
    		get
    		{
    			return _PostalCode;
    		} 
    		set
    		{
    			_PostalCode = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
        
    	private string _City;
    	public string City 
    	{		
    		get
    		{
    			return _City;
    		} 
    		set
    		{
    			_City = String.IsNullOrWhiteSpace(value) ? null : value.Trim();
    		}
     	}
    }
}
