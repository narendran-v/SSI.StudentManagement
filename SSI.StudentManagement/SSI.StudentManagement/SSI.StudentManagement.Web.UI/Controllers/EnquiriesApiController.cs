using SSI.StudentManagement.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SSI.StudentManagement.Domain;
using System.Web.Mvc;

namespace SSI.StudentManagement.Web.UI.Controllers
{
    [System.Web.Http.Authorize]
    public class EnquiriesApiController : ApiController
    {
        private readonly StudentManagementEntities _domainContext;
        IEnumerable<EnquiryModel> list;

        public EnquiriesApiController()
        {
            this.list = GetEnquiries();
            this._domainContext = DependencyResolver.Current.GetService<StudentManagementEntities>();
        }
        // GET api/<EnquiriesApi>
        [ResponseType(typeof(IEnumerable<EnquiryModel>))]
        public IHttpActionResult Get()
        {
            //return (IHttpActionResult)this.Ok<IEnumerable<EnquiryModel>>((IEnumerable<Enquiry>)this._domainContext.Enquiries.ToList().Select<Enquiry, EnquiryModel>((Func<Enquiry, EnquiryModel>)(x => factory.Create(x))));
            return (IHttpActionResult)this.Ok<IEnumerable<EnquiryModel>>(list);
        }

        // GET api/<controller>/5
        [ResponseType(typeof(EnquiryModel))]
        public IHttpActionResult Get(string EnquiryId)
        {
            return (IHttpActionResult)this.Ok(list.Where(c=>c.EnquiryId.Equals(EnquiryId)));
        }

        // POST api/<controller>
        [ResponseType(typeof(EnquiryModel))]
        public IHttpActionResult Post([FromBody]EnquiryModel model)
        {
            List<EnquiryModel> newlist = (List<EnquiryModel>) list;
            model.EnquiryId = "Enq" + (new Random()).Next(100, 1000);
            model.Student.StudentID = "Stu" + (new Random()).Next(100, 1000);
            newlist.Add(model);
            list = newlist;
            return (IHttpActionResult)this.Ok(list.SingleOrDefault(c => c.EnquiryId.Equals(model.EnquiryId)));
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(EnquiryModel))]
        public IHttpActionResult Put(string EnquiryId, [FromBody]EnquiryModel model)
        {
            List<EnquiryModel> newlist = (List<EnquiryModel>)list;
            EnquiryModel newmodel = list.SingleOrDefault(c => c.EnquiryId.Equals(model.EnquiryId));
            newlist.Remove(newmodel);
            model.EnquiryId = EnquiryId;
            newlist.Add(model);
            list = newlist;
            return (IHttpActionResult)this.Ok(list.Where(c => c.EnquiryId.Equals(model.EnquiryId)));
        }

        // DELETE api/<controller>/5
        [ResponseType(typeof(bool))]
        public IHttpActionResult Delete(string EnquiryId)
        {
            List<EnquiryModel> newlist = (List<EnquiryModel>)list;
            EnquiryModel newmodel = list.SingleOrDefault(c => c.EnquiryId.Equals(EnquiryId));
            newlist.Remove(newmodel);
            list = newlist;
            return (IHttpActionResult)this.Ok(true);
        }

        private IEnumerable<EnquiryModel> GetEnquiries()
        {
            List<EnquiryModel> list = new List<EnquiryModel>();
            list.Add(new EnquiryModel() { EnquiryId = "Enq1", CourseId1 = "Java", CourseId2 = "JavaEE", CousellorName="Nithya", EnquiryStatus = "Enquired", EnquiryType = "Walk-in", ExpectedCourseDuration = 3, ExpectedDOJ = new DateTime(2018, 02, 15), Student = new StudentModel() { FirstName = "Naren", LastName = "Venkat", StudentID = "Stu01", Email= "Naren@ssi.com", ContactNumber = "9629423789", DOB = new DateTime(1991, 05, 04) }, AdditionalInfo = "Will be back in two days" });
            list.Add(new EnquiryModel() { EnquiryId = "Enq2", CourseId1 = "Dotnet", CourseId2 = "MVC", CousellorName = "Kasthuri", EnquiryStatus = "Enquired", EnquiryType = "Sulekha", ExpectedCourseDuration = 4, ExpectedDOJ = new DateTime(2018, 01, 15), Student = new StudentModel() { FirstName = "Bhagyalakshmi", LastName = "Shivadasan", StudentID = "Stu02", Email = "Naren@ssi.com", ContactNumber = "9629423789", DOB = new DateTime(1991, 05, 04) }, AdditionalInfo = "Will be back in two days" });
            list.Add(new EnquiryModel() { EnquiryId = "Enq3", CourseId1 = "Oracle", CourseId2 = "Reports & Forms", CousellorName = "Ethiraj", EnquiryStatus = "Enquired", EnquiryType = "JustDial", ExpectedCourseDuration = 5, ExpectedDOJ = new DateTime(2018, 05, 15), Student = new StudentModel() { FirstName = "Nithya", LastName = "Balaji", StudentID = "Stu03", Email = "Naren@ssi.com", ContactNumber = "9629423789", DOB = new DateTime(1991, 05, 04) }, AdditionalInfo = "Will be back in two days" });
            list.Add(new EnquiryModel() { EnquiryId = "Enq4", CourseId1 = "Tally", CourseId2 = "MSOffice", CousellorName = "Deepa", EnquiryStatus = "Enquired", EnquiryType = "Walk-in", ExpectedCourseDuration = 1, ExpectedDOJ = new DateTime(2018, 06, 15), Student = new StudentModel() { FirstName = "Monica", LastName = "Balaji", StudentID = "Stu04", Email = "Naren@ssi.com", ContactNumber = "9629423789", DOB = new DateTime(1991, 05, 04) }, AdditionalInfo = "Will be back in two days" });
            return list;
        }
    }
}