# Fact 5e85a1e9

Store id: 91e4d7fd-6c6e-4427-b6cf-18016bfff43a

## Text

```text
class Star(Expression)
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
- posted_at: `2026-11-09T23:44:49.5421240+00:00`

## Data

```json
{
  "end_line": 1308,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1303,
  "symbol": "Star"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1303,"selector":"L1303-L1308","symbol":"Star"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Star](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1308,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1303,
    "symbol": "Star"
  },
  "id": "91e4d7fd-6c6e-4427-b6cf-18016bfff43a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5421240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1303,
        "selector": "L1303-L1308",
        "symbol": "Star"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e8a1a957-84aa-46a9-a8b6-559edbf9689f",
  "subject_name": "django/db/models/expressions::Star",
  "tags": [
    "entity:class"
  ],
  "text": "class Star(Expression)"
}
```
