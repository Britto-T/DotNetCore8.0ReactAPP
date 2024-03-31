import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';
import { StrictMode } from 'react';

// export default class App extends Component {
//   static displayName = App.name;

//   render() {
//     return (
//       <Layout>
//         <Routes>
//           {AppRoutes.map((route, index) => {
//             const { element, ...rest } = route;
//             return <Route key={index} {...rest} element={element} />;
//           })}
//         </Routes>
//       </Layout>
//     );
//   }
// }

const App =()=>{
let displayName = App.name;

  return (
    <StrictMode>
      <Layout>
        <Routes>
          {AppRoutes.map((route: any, index: any) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
      </Layout>
    </StrictMode>
  );
}

export default App
