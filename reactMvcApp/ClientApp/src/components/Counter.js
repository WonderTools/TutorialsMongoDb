import React, { Component } from 'react';

export class DbConnectionChecker extends Component {

  constructor(props) {
    super(props);
    this.state = { loading: false, connected: false };
    }

    fireDbConnection = () => {
        this.setState({
            loading: true
        })
        fetch('api/connection/testDb')
            .then(response => response.json())
            .then(data => {
                this.setState({ connected: data, loading: false });
            });
    }

    render() {
        const { connected, loading } = this.state
    return (
      <div>
            <h1>DbConnectionChecker</h1>
            
            <p>This is a simple example to test for Database connection Test.</p>

            {!loading &&<div>
                <p><strong>Connection Status:{connected?'true':'false'}</strong></p>
            </div>}
        {
            loading &&
            <div>
                <p><strong>Connecting to Database...</strong></p>
            </div>
        }

        <button onClick={this.fireDbConnection}>Connect</button>
      </div>
    );
  }
}
