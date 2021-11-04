import 'package:flutter/material.dart';

void main() {
  runApp(MaterialApp(home: Home()));
}

class Home extends StatefulWidget {
  const Home({Key? key}) : super(key: key);

  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
          "Álcool ou Gasolina?",
          style: TextStyle(
            color: Colors.white,
          ),
        ),
        centerTitle: true,
        backgroundColor: Colors.lightBlue[900],
        actions: <Widget>[
          IconButton(
              icon: Icon(Icons.refresh),
              onPressed: (){}
          )
        ],
      ),
      body: SingleChildScrollView(
        padding: EdgeInsets.fromLTRB(10.0, 0, 10.0, 0),
        child: Form(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.stretch,
            children: <Widget>[
              Icon(
                Icons.local_gas_station,
                size: 140.0,
                color: Colors.lightBlue[900],
              ),
              TextFormField(
                textAlign: TextAlign.center,
                keyboardType: TextInputType.number,
                decoration: InputDecoration(
                  labelText: "Valor do Alcool",
                  labelStyle: TextStyle(color: Colors.lightBlue[900])
                ),
                style: TextStyle(
                  color: Colors.lightBlue[900],
                  fontSize: 26.0
                ),
              ),
              TextFormField(
                textAlign: TextAlign.center,
                keyboardType: TextInputType.number,
                decoration: InputDecoration(
                    labelText: "Valor do Gasolina",
                    labelStyle: TextStyle(color: Colors.lightBlue[900])
                ),
                style: TextStyle(
                    color: Colors.lightBlue[900],
                    fontSize: 26.0
                ),
              ),
              Padding(
                padding: EdgeInsets.only(top: 20.0, bottom: 20.0),
                child: Container(
                  height: 50.0,
                  child: RaisedButton(
                    onPressed: (){},
                    child: Text(
                      "Verificar",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 25.0
                      ),
                    ),
                    color: Colors.lightBlue[900],
                  ),
                ),
              ),
              Text(
                "Informe os Valores",
                textAlign: TextAlign.center,
                style: TextStyle(
                  color: Colors.lightBlue[900],
                  fontSize: 26.0
                ),
              )
            ],
          )
        ),
      )
    );
  }
}
