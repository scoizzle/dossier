# Fact e1951395

Store id: f1ee5029-4c9d-438f-83c6-fe47c49dbf16

## Text

```text
class TimeField(DateTimeCheckMixin, Field)
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
- posted_at: `2026-11-09T22:39:42.6532150+00:00`

## Data

```json
{
  "end_line": 2716,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2601,
  "symbol": "TimeField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2601,"selector":"L2601-L2716","symbol":"TimeField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2716,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2601,
    "symbol": "TimeField"
  },
  "id": "f1ee5029-4c9d-438f-83c6-fe47c49dbf16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6532150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2601,
        "selector": "L2601-L2716",
        "symbol": "TimeField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b16787ae-9e08-4c43-b8b6-1e829a6c73db",
  "subject_name": "django/db/models/fields/__init__::TimeField",
  "tags": [
    "entity:class"
  ],
  "text": "class TimeField(DateTimeCheckMixin, Field)"
}
```
