# Fact 00eca569

Store id: a4bc32d4-255d-4830-ba34-6c8f66ba0ba1

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
- posted_at: `2026-11-09T23:31:56.5745000+00:00`

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
  "id": "a4bc32d4-255d-4830-ba34-6c8f66ba0ba1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5745000+00:00"
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
  "subject_id": "9dd8f5fe-3091-4c29-8fb5-0853fc83e1ce",
  "subject_name": "django/db/models/fields/__init__::DateField",
  "tags": [
    "entity:class"
  ],
  "text": "class DateField(DateTimeCheckMixin, Field)"
}
```
