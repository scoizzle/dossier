# Fact b5838476

Store id: 917cdd6f-9721-4908-96f4-a895e1d23367

## Text

```text
class FloatField(Field)
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
- posted_at: `2026-11-09T23:44:50.1524280+00:00`

## Data

```json
{
  "end_line": 2138,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2099,
  "symbol": "FloatField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2099,"selector":"L2099-L2138","symbol":"FloatField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FloatField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2138,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2099,
    "symbol": "FloatField"
  },
  "id": "917cdd6f-9721-4908-96f4-a895e1d23367",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1524280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2099,
        "selector": "L2099-L2138",
        "symbol": "FloatField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3a8e5214-046d-43d9-b6c4-f8005e18e4fa",
  "subject_name": "django/db/models/fields/__init__::FloatField",
  "tags": [
    "entity:class"
  ],
  "text": "class FloatField(Field)"
}
```
