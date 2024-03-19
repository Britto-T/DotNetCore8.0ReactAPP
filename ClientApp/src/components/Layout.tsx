import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';

// export class Layout extends Component {
//   static displayName = Layout.name;

//   render() {
//     return (
//       <div>
//         <NavMenu />
//         <Container tag="main">
//           {this.props.children}
//         </Container>
//        </div>     );
//   }
// }

export const Layout = (props:any) => {
  let displayName = Layout.name;

  return (
    <div>
      <NavMenu />
      <Container tag="main">
        {props.children}
      </Container>
    </div>);
}
