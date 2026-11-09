# Fact b3fe997d

Store id: 6764cec7-829e-4d08-a325-df471bff5b18

## Text

```text
class JSONNull(Value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.8651150+00:00`

## Data

```json
{
  "end_line": 1265,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1244,
  "symbol": "JSONNull"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1244,"selector":"L1244-L1265","symbol":"JSONNull"}`

## Items

```json
[
  {
    "text": "Represent JSON `null` primitive.",
    "locator": {
      "line": 1246
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1265,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1244,
    "symbol": "JSONNull"
  },
  "id": "6764cec7-829e-4d08-a325-df471bff5b18",
  "items": [
    {
      "locator": {
        "line": 1246
      },
      "text": "Represent JSON `null` primitive."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8651150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1244,
        "selector": "L1244-L1265",
        "symbol": "JSONNull"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6154c3d7-5b7f-4ed0-9be3-220330774673",
  "subject_name": "django/db/models/expressions::JSONNull",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class JSONNull(Value)"
}
```
