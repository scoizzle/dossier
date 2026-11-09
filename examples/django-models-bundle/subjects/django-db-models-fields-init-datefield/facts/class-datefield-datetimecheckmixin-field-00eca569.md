# Fact 00eca569

Store id: cbac3527-bc22-4f10-b43d-b9e58cf78e5b

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
- posted_at: `2026-11-09T23:44:50.0848680+00:00`

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
  "id": "cbac3527-bc22-4f10-b43d-b9e58cf78e5b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0848680+00:00"
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
  "subject_id": "bd533b80-aa55-48b6-9eef-d90e4ae414c1",
  "subject_name": "django/db/models/fields/__init__::DateField",
  "tags": [
    "entity:class"
  ],
  "text": "class DateField(DateTimeCheckMixin, Field)"
}
```
