# Fact 5ca8447f

Store id: 799658b7-b013-4730-b548-a6b484aee044

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
- posted_at: `2026-11-09T23:31:55.9986160+00:00`

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
  "id": "799658b7-b013-4730-b548-a6b484aee044",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9986160+00:00"
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
  "subject_id": "1b42dc56-2264-4f06-8a44-e4f0cc893996",
  "subject_name": "django/db/models/expressions::Window",
  "tags": [
    "entity:class"
  ],
  "text": "class Window(SQLiteNumericMixin, Expression)"
}
```
