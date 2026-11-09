# Fact b3fe997d

Store id: 2ead5a12-9ed4-4094-ab5d-bb637c68bc67

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
- posted_at: `2026-11-09T23:44:49.5322960+00:00`

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
  "id": "2ead5a12-9ed4-4094-ab5d-bb637c68bc67",
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
    "posted_at": "2026-11-09T23:44:49.5322960+00:00"
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
  "subject_id": "bc9b6ed1-58e3-4ece-bd4c-20ceca0f7926",
  "subject_name": "django/db/models/expressions::JSONNull",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class JSONNull(Value)"
}
```
