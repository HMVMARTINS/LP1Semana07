# LP1Semana07

## Projetos

### ClassVsStruct

Projeto para comparar Classes e Structs

#### Diagrama de Classes

classDiagram
    Class PlayerClass {
        + int Health
        + int Armour
        + void Kill()
    }
    class PlayerStruct {
        + int Health
        + int Armour
        + void Kill()
    }
    PlayerClass <|-- PlayerStruct
