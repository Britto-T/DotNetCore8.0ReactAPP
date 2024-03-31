import { useEffect } from 'react';
import { fetchWeatherDetails } from '../redux/fetchSlice';
import { useAppSelector } from '../redux/hooks';
import { useDispatch } from 'react-redux';

interface Props {

}

export const Weather: React.FC<Props> = () => {

    const weather = useAppSelector((state) => state.fetchSlice.weather);
    const dispatch = useDispatch<any>();

    useEffect(() => {
        dispatch(fetchWeatherDetails());
    }, [dispatch])

    useEffect(() => {
        if(weather){
            console.log(weather,'weather');
        }
    }, [weather])

    return(<>
    Britto
    </>)

}