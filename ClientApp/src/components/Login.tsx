import React, { Component } from 'react'


const Login = ()=>{

    const handleSubmit = (event:any)=>{
        debugger;
        console.log(event);
        event.preventDefault(); // Preven
    }


  return (
    <>
      <form onSubmit={handleSubmit} >
        <div className="container">
          <div className="row">

            <div className="col">
             
            </div>

            <div className="col g-3">
              <div className="container px-4">
                <div className="row gx-5">
                  <div className="p-3 border bg-light">

                    <h3>Sign In</h3>

                    <div className="mb-3 position-relative">
                      <label htmlFor="validationTooltip01" className="form-label">Email address</label>
                      <input type="email" className="form-control" id="validationTooltip01" required placeholder="Enter email" />
                      <div className="invalid-tooltip">
                        Please provide a valid Email address.
                      </div>
                    </div>

                    <div className="mb-3 position-relative">
                      <label htmlFor="validationTooltip02" className="form-label">Password</label>
                      <input type="password" className="form-control" id="validationTooltip02" required placeholder="Enter password" />
                      <div className="invalid-tooltip">
                        Please provide a valid Password.
                      </div>
                    </div>


                    <div className="mb-3">
                      <div className="form-check">
                        <input className="form-check-input" type="checkbox" value="" id="invalidCheck" required />
                        <label className="form-check-label" htmlFor="invalidCheck">
                          Agree to terms and conditions
                        </label>
                        <div className="invalid-feedback">
                          You must agree before submitting.
                        </div>
                      </div>
                    </div>

                    <div className="d-grid">
                      <button className="btn btn-primary" type="submit">Submit form</button>
                    </div>

                    <p className="forgot-password text-right">
                      Forgot <a href="#">password?</a>
                    </p>

                  </div>
                </div>
              </div>
            </div>

            <div className="col">
             
            </div>

          </div> {/* row */}
        </div>  {/* container */}

      </form>


    </>
  )
}

export default Login