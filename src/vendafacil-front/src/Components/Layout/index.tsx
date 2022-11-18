import Aside from '../Aside';
import Content from '../Content';
import MainHeader from '../MainHeader';

import { Grid } from './styles'

function Layout() {
    return(
        <Grid>
            <MainHeader />
            <Aside />
            <Content />
        </Grid>
    )
};

export default Layout;