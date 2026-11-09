# Fact 5ca8447f

Store id: 9735929d-90dc-4532-a885-4e4ddba9dca7

## Text

```text
class Window(SQLiteNumericMixin, Expression)
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
- posted_at: `2026-11-09T23:44:49.6665150+00:00`

## Data

```json
{
  "end_line": 2124,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 2020,
  "symbol": "Window"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2020,"selector":"L2020-L2124","symbol":"Window"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2124,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 2020,
    "symbol": "Window"
  },
  "id": "9735929d-90dc-4532-a885-4e4ddba9dca7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6665150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2020,
        "selector": "L2020-L2124",
        "symbol": "Window"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c02950cf-7f1a-454f-b84e-9e5b74c80799",
  "subject_name": "django/db/models/expressions::Window",
  "tags": [
    "entity:class"
  ],
  "text": "class Window(SQLiteNumericMixin, Expression)"
}
```
