# Fact d59fab60

Store id: e7ec5e68-3311-489e-b91a-05b6a5291cec

## Text

```text
class Aggregate(Func)
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
- posted_at: `2026-11-09T22:39:40.0332650+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 75,
  "symbol": "Aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":75,"selector":"L75-L223","symbol":"Aggregate"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 75,
    "symbol": "Aggregate"
  },
  "id": "e7ec5e68-3311-489e-b91a-05b6a5291cec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0332650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 75,
        "selector": "L75-L223",
        "symbol": "Aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "a4bce9db-89b3-4c1a-a6f4-992f78261c3e",
  "subject_name": "django/db/models/aggregates::Aggregate",
  "tags": [
    "entity:class"
  ],
  "text": "class Aggregate(Func)"
}
```
