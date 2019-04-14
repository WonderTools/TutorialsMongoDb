import React, { Component } from 'react';
import './MovieComponent/movie.css';
import { MovieComponent } from './MovieComponent';
export class Home extends Component {
  displayName = Home.name

    render() {
        return (

            <div>
                <div className="row movie-container">
                    <MovieComponent />
                </div>
             </div>  
    );
  }
}
