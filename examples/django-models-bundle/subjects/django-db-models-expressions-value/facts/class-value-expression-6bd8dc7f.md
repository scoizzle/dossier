# Fact 6bd8dc7f

Store id: 6045d60c-f25c-4fb4-a368-691ee33cea3d

## Text

```text
class Value(Expression)
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
- posted_at: `2026-11-09T23:44:49.5179470+00:00`

## Data

```json
{
  "end_line": 1241,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1147,
  "symbol": "Value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1147,"selector":"L1147-L1241","symbol":"Value"}`

## Items

```json
[
  {
    "text": "Represent a wrapped value as a node within an expression.",
    "locator": {
      "line": 1149
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1241,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1147,
    "symbol": "Value"
  },
  "id": "6045d60c-f25c-4fb4-a368-691ee33cea3d",
  "items": [
    {
      "locator": {
        "line": 1149
      },
      "text": "Represent a wrapped value as a node within an expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5179470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1147,
        "selector": "L1147-L1241",
        "symbol": "Value"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5472c9f1-d91a-40b7-9017-348e4914581b",
  "subject_name": "django/db/models/expressions::Value",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class Value(Expression)"
}
```
