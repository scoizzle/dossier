# Fact 00eca569

Store id: 335afb4d-dbef-4eb9-8055-64cb6ac4a024

## Text

```text
class DateField(DateTimeCheckMixin, Field)
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
- posted_at: `2026-11-09T22:39:42.4107580+00:00`

## Data

```json
{
  "end_line": 1596,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1464,
  "symbol": "DateField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1464,"selector":"L1464-L1596","symbol":"DateField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1596,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1464,
    "symbol": "DateField"
  },
  "id": "335afb4d-dbef-4eb9-8055-64cb6ac4a024",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.4107580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1464,
        "selector": "L1464-L1596",
        "symbol": "DateField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "5c7355d6-1b0d-4e5f-99f8-4e2ffddc9f92",
  "subject_name": "django/db/models/fields/__init__::DateField",
  "tags": [
    "entity:class"
  ],
  "text": "class DateField(DateTimeCheckMixin, Field)"
}
```
