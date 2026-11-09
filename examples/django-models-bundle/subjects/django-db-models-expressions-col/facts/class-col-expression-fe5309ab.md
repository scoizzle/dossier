# Fact fe5309ab

Store id: b3318970-29aa-4582-8de6-45f9bac31624

## Text

```text
class Col(Expression)
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
- posted_at: `2026-11-09T23:44:49.5505820+00:00`

## Data

```json
{
  "end_line": 1387,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1351,
  "symbol": "Col"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1351,"selector":"L1351-L1387","symbol":"Col"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1387,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1351,
    "symbol": "Col"
  },
  "id": "b3318970-29aa-4582-8de6-45f9bac31624",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5505820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1351,
        "selector": "L1351-L1387",
        "symbol": "Col"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9be0b888-6677-4577-8e90-b5c215124bfc",
  "subject_name": "django/db/models/expressions::Col",
  "tags": [
    "entity:class"
  ],
  "text": "class Col(Expression)"
}
```
