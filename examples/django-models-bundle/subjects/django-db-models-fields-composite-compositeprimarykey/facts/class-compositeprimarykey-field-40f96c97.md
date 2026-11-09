# Fact 40f96c97

Store id: 5fd3eaa1-f9e3-41d2-b648-de0bc656d7ef

## Text

```text
class CompositePrimaryKey(Field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.4779570+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "class",
  "parent": "composite",
  "start_line": 50,
  "symbol": "CompositePrimaryKey"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":50,"selector":"L50-L156","symbol":"CompositePrimaryKey"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "class",
    "parent": "composite",
    "start_line": 50,
    "symbol": "CompositePrimaryKey"
  },
  "id": "5fd3eaa1-f9e3-41d2-b648-de0bc656d7ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4779570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 50,
        "selector": "L50-L156",
        "symbol": "CompositePrimaryKey"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "0e7eafa6-817e-4a5b-9884-ee11414a7688",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey",
  "tags": [
    "entity:class"
  ],
  "text": "class CompositePrimaryKey(Field)"
}
```
