﻿import React, { Component } from 'react';
import { Glyphicon } from 'react-bootstrap';
import './movie.css';


export class MovieCard extends Component {
    backGroundStyling = function (movie) {
        return {
            backgroundImage: `url(${movie.url})`
        }
    }

    render() {
        const { movie } = this.props
        return (
            <div className="movie-card">
                <div className="movie-header" style={this.backGroundStyling(movie)} >
                    <div className="header-icon-container">
                        <a href="#">
                            <Glyphicon glyph='play' className="header-icon"/>
                        </a>
                    </div>
                </div>
        </div>

        )
    }
}